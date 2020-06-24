﻿using System;
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
    //Name: Cameron Nepe
    //ID  : 1262199
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Store bookmarks for webpages
        List<string> bookMarks = new List<string>();

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
            textBoxStatus.Clear();
            webBrowserApp.Document.Url.ToString();
            webBrowserApp.DocumentTitle.ToString();
        }

        private void UpdateListBox(List<string> bookMarks)
        {
            //Clears the current items displayed in the listbox
            listBox1.Items.Clear();
            //Goes through each bookmark in the List<> bookMarks 
            foreach (string str in bookMarks)
            {
                //display the URLs to the listbox 
                listBox1.Items.Add(bookMarks);
            }
        }
    }
}
