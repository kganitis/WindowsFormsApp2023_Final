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
            this.ContentPanel.Location = new System.Drawing.Point(818, 48);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.ContentPanel.Size = new System.Drawing.Size(823, 438);
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.Enabled = false;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 689);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GuideForm";
            this.Text = "Αρχική";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}