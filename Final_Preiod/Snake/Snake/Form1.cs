using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Select Border or not
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.Text == "視窗模式") {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
            else if (comboBox1.Text == "無邊框視窗") {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }

        }

        //Game Start Button
        int money = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                money = Convert.ToInt32(textBox1.Text);
            }
            catch {
                MessageBox.Show("請輸入正確的數字，謝謝惠顧。");
            }
        }
    }
}
