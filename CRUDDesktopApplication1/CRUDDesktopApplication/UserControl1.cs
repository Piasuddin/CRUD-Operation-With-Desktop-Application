﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDesktopApplication
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnStartNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey i'm Pias! You are in my site. Thanks to Stay With us...");
        }
    }
}
