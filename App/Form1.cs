﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSentencia_Click(object sender, EventArgs e)
        {
            PruebaSentencia frm = new PruebaSentencia();
            frm.Show();
        }
    }
}