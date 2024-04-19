using System;
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
    public partial class LogInWater : Form
    {
        public LogInWater()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WaiterForm3 waiterForm3 = new WaiterForm3();
            waiterForm3.ShowDialog();
        }
    }
}
