﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms.HelpfulTips
{
    public partial class ResidentEvacuationRoomControl : UserControl
    {
        public ResidentEvacuationRoomControl(string roomName, int capacity)
        {
            InitializeComponent();
            labelRoomName.Text = roomName;
            labelCapacity.Text = $"Family Capacity: {capacity}";
        }
    }
}