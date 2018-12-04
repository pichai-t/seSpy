using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeSpy
{
    public partial class frmSeSpy : Form
    {
        public frmSeSpy()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbrMain.Navigate((txtURL.Text.Trim()));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSeSpy_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtURL;
            txtURL.Focus();
        }


        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo_Click(this, e);
            }
        }

        // ===================
        // Mouse Down Event
        // ===================
        private void browser_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.wbrMain.Document.Body.MouseDown += new HtmlElementEventHandler(Body_MouseDown);
        }
        void Body_MouseDown(Object sender, HtmlElementEventArgs e)
        {
            switch (e.MouseButtonsPressed)
            {

                case MouseButtons.Right:
                    HtmlElement element = this.wbrMain.Document.GetElementFromPoint(e.ClientMousePosition);
                    //System.Collections<HtmlElement> element2 = wbrMain.Document.GetElementsByTagName("body");

                    var savedId = element.Id;
                    var uniqueId = Guid.NewGuid().ToString();
                    element.Id = uniqueId;

                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(element.Document.GetElementsByTagName("html")[0].OuterHtml);
                    element.Id = savedId;
                    
                    var node = doc.GetElementbyId(uniqueId);
                    // var nodeID = node.Id;
                    var xpath = node.XPath;
                    rtbNote.Text = rtbNote.Text + Environment.NewLine + "XPATH: " + xpath;
                    
                    break;

            }

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            rtbNote.Clear();
        }
    }
}
