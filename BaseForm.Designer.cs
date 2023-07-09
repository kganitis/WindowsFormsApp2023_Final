﻿namespace WindowsFormsApp2023_Final
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.NavButtonHome = new System.Windows.Forms.Button();
            this.NavButtonBack = new System.Windows.Forms.Button();
            this.NavButton5 = new System.Windows.Forms.Button();
            this.NavButton4 = new System.Windows.Forms.Button();
            this.NavButton3 = new System.Windows.Forms.Button();
            this.NavButton2 = new System.Windows.Forms.Button();
            this.NavButton1 = new System.Windows.Forms.Button();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ListenButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.testLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.NavigationPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.LightGray;
            this.NavigationPanel.Controls.Add(this.NavButtonHome);
            this.NavigationPanel.Controls.Add(this.NavButtonBack);
            this.NavigationPanel.Controls.Add(this.NavButton5);
            this.NavigationPanel.Controls.Add(this.NavButton4);
            this.NavigationPanel.Controls.Add(this.NavButton3);
            this.NavigationPanel.Controls.Add(this.NavButton2);
            this.NavigationPanel.Controls.Add(this.NavButton1);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 24);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(200, 537);
            this.NavigationPanel.TabIndex = 0;
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.BackColor = System.Drawing.Color.CadetBlue;
            this.NavButtonHome.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.home;
            this.NavButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButtonHome.Location = new System.Drawing.Point(10, 18);
            this.NavButtonHome.Name = "NavButtonHome";
            this.NavButtonHome.Size = new System.Drawing.Size(180, 80);
            this.NavButtonHome.TabIndex = 6;
            this.NavButtonHome.UseVisualStyleBackColor = false;
            this.NavButtonHome.Click += new System.EventHandler(this.NavButtonHome_Click);
            // 
            // NavButtonBack
            // 
            this.NavButtonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButtonBack.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.restart;
            this.NavButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButtonBack.Location = new System.Drawing.Point(10, 447);
            this.NavButtonBack.Name = "NavButtonBack";
            this.NavButtonBack.Size = new System.Drawing.Size(180, 80);
            this.NavButtonBack.TabIndex = 5;
            this.NavButtonBack.UseVisualStyleBackColor = false;
            this.NavButtonBack.Click += new System.EventHandler(this.NavButtonBack_Click);
            // 
            // NavButton5
            // 
            this.NavButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton5.Location = new System.Drawing.Point(10, 377);
            this.NavButton5.Name = "NavButton5";
            this.NavButton5.Size = new System.Drawing.Size(180, 60);
            this.NavButton5.TabIndex = 4;
            this.NavButton5.Text = "Φωτογραφίες";
            this.NavButton5.UseVisualStyleBackColor = false;
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton4.Location = new System.Drawing.Point(10, 311);
            this.NavButton4.Name = "NavButton4";
            this.NavButton4.Size = new System.Drawing.Size(180, 60);
            this.NavButton4.TabIndex = 3;
            this.NavButton4.Text = "Αξιολογήσεις";
            this.NavButton4.UseVisualStyleBackColor = false;
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton3.Location = new System.Drawing.Point(10, 245);
            this.NavButton3.Name = "NavButton3";
            this.NavButton3.Size = new System.Drawing.Size(180, 60);
            this.NavButton3.TabIndex = 2;
            this.NavButton3.Text = "Σχολές";
            this.NavButton3.UseVisualStyleBackColor = false;
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton2.Location = new System.Drawing.Point(10, 179);
            this.NavButton2.Name = "NavButton2";
            this.NavButton2.Size = new System.Drawing.Size(180, 60);
            this.NavButton2.TabIndex = 1;
            this.NavButton2.Text = "Υπηρεσίες";
            this.NavButton2.UseVisualStyleBackColor = false;
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // NavButton1
            // 
            this.NavButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NavButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavButton1.Location = new System.Drawing.Point(10, 113);
            this.NavButton1.Name = "NavButton1";
            this.NavButton1.Size = new System.Drawing.Size(180, 60);
            this.NavButton1.TabIndex = 0;
            this.NavButton1.Text = "Πανεπιστήμιο";
            this.NavButton1.UseVisualStyleBackColor = false;
            this.NavButton1.Click += new System.EventHandler(this.NavButton1_Click);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.LightGray;
            this.ToolsPanel.Controls.Add(this.ExitButton);
            this.ToolsPanel.Controls.Add(this.ListenButton);
            this.ToolsPanel.Controls.Add(this.ExportButton);
            this.ToolsPanel.Controls.Add(this.AboutButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolsPanel.Location = new System.Drawing.Point(200, 461);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(784, 100);
            this.ToolsPanel.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.close;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Location = new System.Drawing.Point(608, 10);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(120, 80);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ListenButton
            // 
            this.ListenButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.speaker;
            this.ListenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListenButton.Location = new System.Drawing.Point(422, 10);
            this.ListenButton.Margin = new System.Windows.Forms.Padding(0);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(120, 80);
            this.ListenButton.TabIndex = 3;
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.save;
            this.ExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExportButton.Location = new System.Drawing.Point(236, 10);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(120, 80);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.about;
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AboutButton.Location = new System.Drawing.Point(50, 10);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(120, 80);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.testLabel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 24);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ContentPanel.Size = new System.Drawing.Size(784, 437);
            this.ContentPanel.TabIndex = 2;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(13, 179);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(755, 120);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = resources.GetString("testLabel.Text");
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(984, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πανεπιστήμιο Πειραιώς";
            this.NavigationPanel.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected void HideAllControls()
        {
            HideExportAndListenControls();
            HideNavigationControls();
        }

        protected void HideNavigationControls()
        {
            // 
            // NavButton1
            // 
            this.NavButton1.Visible = false;
            // 
            // NavButtonBack
            // 
            this.NavButtonBack.Visible = false;
            // 
            // NavButton5
            // 
            this.NavButton5.Visible = false;
            // 
            // NavButton4
            // 
            this.NavButton4.Visible = false;
            // 
            // NavButton3
            // 
            this.NavButton3.Visible = false;
            // 
            // NavButton2
            // 
            this.NavButton2.Visible = false;
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.Visible = false;
        }

        protected void HideExportAndListenControls()
        {
            // 
            // ExportButton
            // 
            this.ExportButton.Visible = false;
            // 
            // ListenButton
            // 
            this.ListenButton.Visible = false;
        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel ToolsPanel;
        protected System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button AboutButton;
        protected System.Windows.Forms.Button ExportButton;
        protected System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button ExitButton;
        protected System.Windows.Forms.Button NavButton1;
        protected System.Windows.Forms.Button NavButtonBack;
        protected System.Windows.Forms.Button NavButton5;
        protected System.Windows.Forms.Button NavButton4;
        protected System.Windows.Forms.Button NavButton3;
        protected System.Windows.Forms.Button NavButton2;
        protected System.Windows.Forms.Button NavButtonHome;
        private System.Windows.Forms.MenuStrip MenuStrip;
        protected System.Windows.Forms.Label testLabel;
    }
}