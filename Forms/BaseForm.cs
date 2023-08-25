﻿using System;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class BaseForm : Form
    {
        protected String connectionString = "Data source=rad19900.db;Version=3;";
        protected SpeechSynthesizer engine;
        protected Button highlightedButton;
        protected Color highlightedButtonColor = Color.BurlyWood;
        protected Color defaultButtonColor = SystemColors.Control;
        
        public BaseForm()
        {
            InitializeComponent();
            engine = new SpeechSynthesizer();

            // Αν πρόκειται για AboutForm, disable τα σχετικά κουμπιά
            if (GetType() == typeof(AboutForm))
            {
                AboutButton.Enabled = false;
                HelpToolStripMenuItem.Enabled = false;
            }
        }

        private void Export()
        {
            string textToExport = Text;
            string filename = Text;
            string filePath = "..\\..\\exports\\" + filename + ".txt";
            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(textToExport);
            MessageBox.Show("Οι πληροφορίες εξήχθησαν με επιτυχία!");
            writer.Close();
        }

        #region Controls Handling Methods

        protected void HighlightButton(Button button)
        {
            highlightedButton = button;
            button.Enabled = false;
            button.BackColor = highlightedButtonColor;
        }

        protected void ResetHighlightedButton()
        {
            if (highlightedButton != null)
            {
                highlightedButton.Enabled = true;
                highlightedButton.BackColor = defaultButtonColor;
                highlightedButton = null;
            }
        }

        protected void HideAllControls()
        {
            HideExportAndListenControls();
            HideNavigationControls();
        }

        protected void HideNavigationControls()
        {
            NavButtonHome.Visible = false;
            NavButton1.Visible = false;
            NavButton2.Visible = false;
            NavButton3.Visible = false;
            NavButton4.Visible = false;
            NavButton5.Visible = false;
            NavButtonBack.Visible = false;
            HomeToolStripMenuItem.Enabled = false;
            UniversityToolStripMenuItem.Enabled = false;
            ServicesToolStripMenuItem.Enabled = false;
            SchoolsToolStripMenuItem.Enabled = false;
            ReviewsToolStripMenuItem.Enabled = false;
            SlideshowToolStripMenuItem.Enabled = false;
            BackToolStripMenuItem.Enabled = false;
        }

        protected void HideExportAndListenControls()
        {
            ExportButton.Visible = false;
            ListenButton.Visible = false;
            ToolsToolStripMenuItem.Enabled = false;
            ExportToolStripMenuItem.Enabled = false;
            ListenToolStripMenuItem.Enabled = false;
        }

        #endregion

        #region Navigation Buttons Methods

        protected void NavigateToForm<T>() where T : BaseForm, new()
        {
            FormCacheManager.Instance.NavigateToForm<T>(this);
        }

        protected virtual void NavButtonHome_Click(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
        }

        protected virtual void NavButton1_Click(object sender, EventArgs e)
        {
            NavigateToForm<UniversitySectionForm>();
        }

        protected virtual void NavButton2_Click(object sender, EventArgs e)
        {
            NavigateToForm<ServicesSectionForm>();
        }

        protected virtual void NavButton3_Click(object sender, EventArgs e)
        {
            NavigateToForm<SchoolsSectionForm>();
        }

        protected virtual void NavButton4_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewsForm>();
        }

        protected virtual void NavButton5_Click(object sender, EventArgs e)
        {
            NavigateToForm<SlideshowForm>();
        }

        protected void NavButtonBack_Click(object sender, EventArgs e)
        {
            FormCacheManager.Instance.NavigateBack(this);
        }

        public void EnableBackButton(BaseForm previousForm)
        {
            NavButtonBack.Enabled = true;
            NavButtonBack.Text = String.Concat("Πίσω σε " , previousForm.Text);
        }

        public void DisableBackButton()
        {
            NavButtonBack.Enabled = false;
            NavButtonBack.Text = "";
        }

        #endregion

        #region Tool Buttons Methods

        private void AboutButton_Click(object sender, EventArgs e)
        {
            NavigateToForm<AboutForm>();
        }

        protected virtual void ExportButton_Click(object sender, EventArgs e)
        {
            Export();
        }

        protected virtual void ListenButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Menu Strip Items Methods

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<GuideForm>();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCacheManager.Instance.NavigateBack(this);
        }

        private void UniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<UniversitySectionForm>();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<ServicesSectionForm>();
        }

        private void SchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<SchoolsSectionForm>();
        }

        private void ReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<ReviewsForm>();
        }

        private void SlideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<SlideshowForm>();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void ListenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateToForm<AboutForm>();
        }

        #endregion
    }
}