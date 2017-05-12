﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlenkaMyClaudPlayer
{
    public partial class frmNet : Form
    {
        public static int NetNumber = 20;
        gblClass objMainClass = new gblClass();
        public frmNet()
        {
            InitializeComponent();
            
        }

        private void frmNet_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.more;
            lblExperyMsg.Text = StaticClass.PlayerExpiryMessage;
        }

        private void frmNet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
