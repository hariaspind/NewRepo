﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome Gomathi shanmugam");
            MessageBox.Show("Welcome Harishankar");
        }
        private int Add()
        {
            var  x = 1;
            var  y = 2;
            var z = x + y;
            return z;
        }
    }
}
//Hari edited in Github website
