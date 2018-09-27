using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HW1_4
{
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Rename Label
            label1.Text = "UP";
            label2.Text = "DOWN";
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
            

        private void button2_Click(object sender, EventArgs e) {
            //Rename Label
            label1.Text = "DOWN";
            label2.Text = "UP";
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e) {
            //Easter Egg
            label1.Text = "ouch!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top -= 10;
            label2.Top += 10;
            if (label1.Top < 80) {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Top += 10;
            label2.Top -= 10;
            if (label2.Top < 80)
            {
                timer2.Enabled = false;
            }
        }
    }
}
