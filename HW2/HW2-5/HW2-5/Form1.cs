using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_5
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            label2.Left -= 1;
            if (label2.Left <= 0) {
                timer2.Enabled = true;
            } else if (label2.Left <= -99) {
                label2.Left = 522;
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) {
            label1.Left -= 1;
            if (label1.Left <= 0) {
                timer1.Enabled = true;
            } else if (label1.Left <= -99) {
                label1.Left = 522;
                timer2.Enabled = false;
            }
        }
    }
}
