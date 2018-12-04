namespace SeSpy
{
    partial class frmSeSpy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeSpy));
            this.wbrMain = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbrMain
            // 
            this.wbrMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbrMain.Location = new System.Drawing.Point(-1, 56);
            this.wbrMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbrMain.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbrMain.Name = "wbrMain";
            this.wbrMain.Size = new System.Drawing.Size(1006, 654);
            this.wbrMain.TabIndex = 0;
            this.wbrMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(104, 16);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(371, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(485, 13);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(56, 25);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1155, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNote.Location = new System.Drawing.Point(1009, 56);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(221, 655);
            this.rtbNote.TabIndex = 4;
            this.rtbNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL";
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(556, 13);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(56, 25);
            this.btnFwd.TabIndex = 6;
            this.btnFwd.Text = "Forward";
            this.btnFwd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 25);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(1009, 19);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(75, 23);
            this.btnClearText.TabIndex = 8;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // frmSeSpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 720);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.wbrMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSeSpy";
            this.Text = "Selenium Spy";
            this.Load += new System.EventHandler(this.frmSeSpy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrMain;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearText;
    }
}

