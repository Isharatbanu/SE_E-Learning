﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_Platform
{
    public partial class Form1 : Form
    {
        Homepage h = new Homepage();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            h.Show();
            this.Hide();
        }
    }
}
