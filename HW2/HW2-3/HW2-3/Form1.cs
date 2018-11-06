using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_3
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        int a = 134000, b = 114850, c = 105980;

        private void button1_Click(object sender, EventArgs e) {
            int total=0;
            if (checkBox1.Checked) {
                total += a;
            }
            if (checkBox2.Checked) {
                total += b;
            }
            if (checkBox3.Checked) {
                total += c;
            }
            if (total >= 134001) {
                label2.Text = "金額為:" + Convert.ToString(total) + "，請選贈品";
                groupBox2.Enabled = true;
                button2.Enabled = true;
            }else {
                label2.Text = "金額為:" + Convert.ToString(total) + "，您太窮了，贈品配不上您";
                groupBox2.Enabled = false;
                button2.Enabled = false;
            }

        }


        private void button2_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                label3.Text = "AF-S 70-200mm f/2.8G ED VR II";
            }
            if (radioButton2.Checked)
            {
                label3.Text = "AF-S NIKKOR 50mm f/1.8G";
            }
        }

        


        private void Form1_Load(object sender, EventArgs e) {
            
        }

        

    }
}
