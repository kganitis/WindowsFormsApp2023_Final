﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class BaseForm : Form
    {
        internal FormCacheManager cacheManager;
        protected Color highlightedButtonColor = Color.BurlyWood;
        
        public BaseForm()
        {
            InitializeComponent();
            cacheManager = FormCacheManager.Instance;
            if (GetType() == typeof(AboutForm))
            {
                AboutButton.Enabled = false;
            }
        }

        protected void HighlightButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = highlightedButtonColor;
        }

        protected void NavigateToForm<T>() where T : Form, new()
        {
            cacheManager.NavigateToForm<T>(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NavButtonHome_Click(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
        }

        private void NavButton1_Click(object sender, EventArgs e)
        {
            NavigateToForm<UniversitySectionForm>();
        }

        private void NavButton2_Click(object sender, EventArgs e)
        {
            NavigateToForm<ServicesSectionForm>();
        }

        private void NavButton3_Click(object sender, EventArgs e)
        {
            NavigateToForm<SchoolsSectionForm>();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<AboutForm>();
        }

        private void NavButtonBack_Click(object sender, EventArgs e)
        {
            cacheManager.NavigateBack(this);
        }

        private void NavButton4_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewsForm>();
        }

        private void NavButton5_Click(object sender, EventArgs e)
        {
            NavigateToForm<SlideshowForm>();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            string textToExport = testLabel.Text;
            string filename = "..\\..\\exports\\test.txt";
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(textToExport);
            MessageBox.Show("Οι πληροφορίες εξήχθησαν με επιτυχία!");
            writer.Close();
        }
    }
}
