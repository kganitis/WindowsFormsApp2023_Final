﻿namespace WindowsFormsApp2023_Final
{
    partial class GuideForm
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
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.Enabled = false;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuideForm";
            this.Text = "Οδηγός Πανεπιστημίου";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
