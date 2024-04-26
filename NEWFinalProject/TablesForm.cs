using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEWFinalProject
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label6.Text = "Occupied";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label6.Text = "Free";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Free";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Occupied";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Free";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Occupied";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Free";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "Occupied";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "Free";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = "Occupied";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = "Free";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = "Occupied";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label7.Text = "Free";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label7.Text = "Occupied";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label8.Text = "Free";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label8.Text = "Occupied";
        }

        
    }
}
