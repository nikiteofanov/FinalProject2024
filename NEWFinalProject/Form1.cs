﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            LogInWater logInWater = new LogInWater();
            logInWater.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerLogIn managerLogIn = new ManagerLogIn();
            managerLogIn.Show();
        }
    }
}
