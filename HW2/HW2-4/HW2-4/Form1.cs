using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace HW2_4
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                decimal num = Convert.ToInt32(textBox1.Text);
                if (num < 10 || num > 50) {
                    MessageBox.Show("請輸入正確範圍的數字");
                }
                /*
                decimal wer = num / 2;
                Debug.Print(wer.ToString());
                */
                
                if (num % 2 != 0) {
                    num += 1;
                    Debug.Print(num.ToString());
                }

                decimal numss = 0; 
                for (decimal i = num; i <= 50; i+=2) {
                    numss = numss + i;
                    label3.Text = numss.ToString();
                    Debug.Print(i.ToString());
                    Debug.Print(num.ToString());
                }

            }
            catch (Exception ee) {
                MessageBox.Show("發生未預期的錯誤，請聯絡系統管理員。");
            }
        }
    }
}
