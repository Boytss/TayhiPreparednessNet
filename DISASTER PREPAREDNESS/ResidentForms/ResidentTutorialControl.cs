﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentTutorialControl : UserControl
    {
        public ResidentTutorialControl()
        {
            InitializeComponent();
        }
        public void SetTutorialText(string text)
        {
            labelTutorialText.Text = text;
        }
    }
}