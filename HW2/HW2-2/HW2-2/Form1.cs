using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_2
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        int x = 0, y = 0, r = 0;

        private void Form1_Load(object sender, EventArgs e) {
            radioButton1.Select();
        }

        private void button1_Click(object sender, EventArgs e) {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);

                if (radioButton1.Checked)
                {
                    r = x + y;
                    label3.Text = r.ToString();
                }
                else if (radioButton2.Checked)
                {
                    r = x - y;
                    label3.Text = r.ToString();
                };
            }
            catch (Exception aa)
            {
                MessageBox.Show("你再亂打試試看");
            }
            
        }
    }
}
