namespace WebBrowser
{
    partial class Form1
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
            this.webBrowserApp = new System.Windows.Forms.WebBrowser();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookmarkFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookmarkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserApp
            // 
            this.webBrowserApp.Location = new System.Drawing.Point(0, 60);
            this.webBrowserApp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserApp.Name = "webBrowserApp";
            this.webBrowserApp.Size = new System.Drawing.Size(800, 390);
            this.webBrowserApp.TabIndex = 0;
            this.webBrowserApp.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserApp_DocumentCompleted);
            this.webBrowserApp.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserApp_Navigating);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(183, 34);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(482, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(12, 418);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(171, 20);
            this.textBoxStatus.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(8, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(89, 34);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 23);
            this.buttonForward.TabIndex = 4;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(680, 31);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Accept";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(657, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookmarkFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBookmarkFileToolStripMenuItem
            // 
            this.newBookmarkFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookmarkFileToolStripMenuItem1,
            this.loadBookmarkFileToolStripMenuItem,
            this.saveBookmarkFileToolStripMenuItem,
            this.addBookmarkToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.newBookmarkFileToolStripMenuItem.Name = "newBookmarkFileToolStripMenuItem";
            this.newBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newBookmarkFileToolStripMenuItem.Text = "File";
            // 
            // newBookmarkFileToolStripMenuItem1
            // 
            this.newBookmarkFileToolStripMenuItem1.Name = "newBookmarkFileToolStripMenuItem1";
            this.newBookmarkFileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newBookmarkFileToolStripMenuItem1.Text = "New Bookmark File";
            this.newBookmarkFileToolStripMenuItem1.Click += new System.EventHandler(this.newBookmarkFileToolStripMenuItem1_Click);
            // 
            // loadBookmarkFileToolStripMenuItem
            // 
            this.loadBookmarkFileToolStripMenuItem.Name = "loadBookmarkFileToolStripMenuItem";
            this.loadBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadBookmarkFileToolStripMenuItem.Text = "Load Bookmark File";
            // 
            // saveBookmarkFileToolStripMenuItem
            // 
            this.saveBookmarkFileToolStripMenuItem.Name = "saveBookmarkFileToolStripMenuItem";
            this.saveBookmarkFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveBookmarkFileToolStripMenuItem.Text = "Save Bookmark File";
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.webBrowserApp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserApp;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookmarkFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBookmarkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

