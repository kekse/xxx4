﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace look.sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.endgeil();

        }

        private void endgeil() { MessageBox.Show("Hello World!"); }

    }
}