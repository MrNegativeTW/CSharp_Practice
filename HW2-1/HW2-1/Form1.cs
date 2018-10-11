using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_1
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        int a = 0;
        private void button1_Click(object sender, EventArgs e) {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                if (a >= 80 && a <= 100)
                {
                    label1.Text = "甲等";
                }
                else if (a >= 60 && a <= 79)
                {
                    label1.Text = "乙等";
                }
                else if (a <= 59 && a >= 0)
                {
                    label1.Text = "不及格";
                }
                else
                {
                    label1.Text = "你再亂打試試看";
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Numbers only, thanks.");
            }


            

        }
    }
}
