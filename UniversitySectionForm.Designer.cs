﻿namespace WindowsFormsApp2023_Final
{
    partial class UniversitySectionForm
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
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(267, 30);
            this.ContentPanel.Size = new System.Drawing.Size(1045, 537);
            // 
            // NavButton1
            // 
            this.NavButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.NavButton1.Location = new System.Drawing.Point(13, 128);
            this.NavButton1.Text = "Πανεπιστήμιο";
            this.NavButton1.Click += new System.EventHandler(this.NavButton1_Click);
            // 
            // NavButton5
            // 
            this.NavButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.NavButton5.Location = new System.Drawing.Point(13, 452);
            this.NavButton5.Size = new System.Drawing.Size(240, 86);
            this.NavButton5.Text = "Τοποθεσία - Πρόσβαση";
            // 
            // NavButton4
            // 
            this.NavButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.NavButton4.Location = new System.Drawing.Point(13, 394);
            this.NavButton4.Size = new System.Drawing.Size(240, 50);
            this.NavButton4.Text = "Περιήγηση";
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.NavButton3.Location = new System.Drawing.Point(13, 295);
            this.NavButton3.Size = new System.Drawing.Size(240, 91);
            this.NavButton3.Text = "Στρατηγική Πανεπιστημίου";
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.NavButton2.Location = new System.Drawing.Point(13, 210);
            this.NavButton2.Size = new System.Drawing.Size(240, 83);
            this.NavButton2.Text = "Χαιρετισμός\r\nΠρύτανη";
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // testLabel
            // 
            this.testLabel.Location = new System.Drawing.Point(440, 210);
            this.testLabel.Size = new System.Drawing.Size(136, 16);
            this.testLabel.Text = "Χαιρετισμός Πρύτανη";
            // 
            // UniversitySectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "UniversitySectionForm";
            this.Text = "Πανεπιστήμιο";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
