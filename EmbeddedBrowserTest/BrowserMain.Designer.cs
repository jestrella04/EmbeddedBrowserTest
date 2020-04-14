namespace EmbeddedBrowserTest
{
    partial class BrowserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnLinks = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemQaTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemIntegrator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.btnGoForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelUrl = new System.Windows.Forms.ToolStripLabel();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGoToUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.btnClearCache = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainEmbeddedBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnLinks,
            this.toolStripSeparator3,
            this.btnGoBack,
            this.btnGoForward,
            this.toolStripSeparator1,
            this.labelUrl,
            this.txtUrl,
            this.btnGoToUrl,
            this.toolStripSeparator4,
            this.btnStop,
            this.btnReload,
            this.btnClearCache,
            this.toolStripSeparator2,
            this.btnInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(1008, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(3);
            this.btnHome.Size = new System.Drawing.Size(26, 27);
            this.btnHome.Text = "Go Home";
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQaTools,
            this.menuItemIntegrator});
            this.btnLinks.Image = ((System.Drawing.Image)(resources.GetObject("btnLinks.Image")));
            this.btnLinks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinks.Margin = new System.Windows.Forms.Padding(0);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Padding = new System.Windows.Forms.Padding(3);
            this.btnLinks.Size = new System.Drawing.Size(35, 27);
            this.btnLinks.Text = "Quick Links";
            // 
            // menuItemQaTools
            // 
            this.menuItemQaTools.Name = "menuItemQaTools";
            this.menuItemQaTools.Size = new System.Drawing.Size(187, 22);
            this.menuItemQaTools.Text = "QA Tools";
            this.menuItemQaTools.Click += new System.EventHandler(this.MenuItemQaTools_Click);
            // 
            // menuItemIntegrator
            // 
            this.menuItemIntegrator.Name = "menuItemIntegrator";
            this.menuItemIntegrator.Size = new System.Drawing.Size(187, 22);
            this.menuItemIntegrator.Text = "Integrations Test Tool";
            this.menuItemIntegrator.Click += new System.EventHandler(this.MenuItemIntegrator_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Padding = new System.Windows.Forms.Padding(3);
            this.btnGoBack.Size = new System.Drawing.Size(26, 27);
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // btnGoForward
            // 
            this.btnGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoForward.Image = ((System.Drawing.Image)(resources.GetObject("btnGoForward.Image")));
            this.btnGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoForward.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Padding = new System.Windows.Forms.Padding(3);
            this.btnGoForward.Size = new System.Drawing.Size(26, 27);
            this.btnGoForward.Text = "Go Forward";
            this.btnGoForward.Click += new System.EventHandler(this.BtnGoForward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // labelUrl
            // 
            this.labelUrl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(34, 24);
            this.labelUrl.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(600, 27);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUrl_KeyDown);
            // 
            // btnGoToUrl
            // 
            this.btnGoToUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToUrl.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToUrl.Image")));
            this.btnGoToUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToUrl.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGoToUrl.Name = "btnGoToUrl";
            this.btnGoToUrl.Padding = new System.Windows.Forms.Padding(3);
            this.btnGoToUrl.Size = new System.Drawing.Size(26, 27);
            this.btnGoToUrl.Text = "Load URL";
            this.btnGoToUrl.Click += new System.EventHandler(this.BtnGoToUrl_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Padding = new System.Windows.Forms.Padding(3);
            this.btnStop.Size = new System.Drawing.Size(26, 27);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(3);
            this.btnReload.Size = new System.Drawing.Size(26, 27);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnClearCache
            // 
            this.btnClearCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearCache.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCache.Image")));
            this.btnClearCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearCache.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Padding = new System.Windows.Forms.Padding(3);
            this.btnClearCache.Size = new System.Drawing.Size(26, 27);
            this.btnClearCache.Text = "toolStripButton1";
            this.btnClearCache.ToolTipText = "Clear Cache";
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnInfo
            // 
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(3);
            this.btnInfo.Size = new System.Drawing.Size(26, 27);
            this.btnInfo.Text = "Information";
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 17);
            this.lblStatus.Text = "Loading...";
            // 
            // mainEmbeddedBrowser
            // 
            this.mainEmbeddedBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEmbeddedBrowser.Location = new System.Drawing.Point(0, 37);
            this.mainEmbeddedBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainEmbeddedBrowser.Name = "mainEmbeddedBrowser";
            this.mainEmbeddedBrowser.Size = new System.Drawing.Size(1008, 702);
            this.mainEmbeddedBrowser.TabIndex = 3;
            this.mainEmbeddedBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MainEmbeddedBrowser_DocumentCompleted);
            this.mainEmbeddedBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.MainEmbeddedBrowser_Navigating);
            // 
            // BrowserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.mainEmbeddedBrowser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserMain";
            this.Text = "Embedded Browser Test";
            this.Load += new System.EventHandler(this.BrowserMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripLabel labelUrl;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGoToUrl;
        private System.Windows.Forms.ToolStripDropDownButton btnLinks;
        private System.Windows.Forms.ToolStripMenuItem menuItemQaTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemIntegrator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGoBack;
        private System.Windows.Forms.ToolStripButton btnGoForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.WebBrowser mainEmbeddedBrowser;
        private System.Windows.Forms.ToolStripButton btnClearCache;
    }
}

