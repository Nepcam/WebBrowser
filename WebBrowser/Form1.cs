using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowserApp.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowserApp.GoForward();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowserApp.Navigate(textBoxURL.Text);
        }

        private void webBrowserApp_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            textBoxStatus.Text = "Loading..."; 
        }

        private void webBrowserApp_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserApp.Document.Url.ToString();
        }
    }
}
