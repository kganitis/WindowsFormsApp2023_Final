﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public partial class UniversitySectionForm : WindowsFormsApp2023_Final.GuideSectionForm
    {
        public UniversitySectionForm()
        {
            InitializeComponent();
        }

        private void NavButtonBack_Click(object sender, EventArgs e)
        {
            cacheManager.NavigateToForm<GuideIntroForm>();
        }
    }
}
