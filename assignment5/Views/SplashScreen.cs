﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        /// <summary>
        /// This is the event handler for the splashtimer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
