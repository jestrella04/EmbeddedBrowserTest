using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbeddedBrowserTest
{
    public partial class BrowserMain : Form
    {
        public BrowserMain()
        {
            InitializeComponent();
        }

        private void BrowserMain_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready.";
            txtUrl.Focus();
            txtUrl.PerformClick();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.GoHome();
        }

        private void MenuItemQaTools_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.Navigate("https://staging.cenpos.com/qatools");
        }

        private void MenuItemIntegrator_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.Navigate("https://staging.cenpos.com/qatools/integrator/");
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.GoBack();
        }

        private void BtnGoForward_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.GoForward();
        }

        private void BtnGoToUrl_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            mainEmbeddedBrowser.Navigate(url);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.Stop();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            mainEmbeddedBrowser.Refresh();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog(this);
        }

        private void TxtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGoToUrl.PerformClick();
            }
        }

        private void MainEmbeddedBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lblStatus.Text = "Loading... " + e.Url.ToString();
        }

        private void MainEmbeddedBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = mainEmbeddedBrowser.Url.ToString();
            lblStatus.Text = "Completed.";
        }
    }
}
