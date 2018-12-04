using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_1
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

        int cash = 0;
        int shopping = 0;
        int change = 0;
        int[] money = {1000, 500, 100, 50, 10, 5, 1};
        int[] result = {0, 0, 0, 0, 0, 0, 0 };
        int[] midresult = {0, 0, 0, 0, 0, 0, 0, 0};
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cash = Convert.ToInt16(textBox1.Text);
                shopping = Convert.ToInt16(textBox2.Text);
                if (cash < shopping) {
                    MessageBox.Show("收現不足");
                } else if (cash > shopping) {
                    change = cash - shopping;
                    textBox3.Text = change.ToString();
                    midresult[0] = change;
                    for (int i = 0; i < money.Length; i++) {
                        result[i] = midresult[i] / money[i];
                        midresult[i + 1] = midresult[i] % money[i];
                    }
                    textBox4.Text = result[0].ToString();
                    textBox5.Text = result[1].ToString();
                    textBox6.Text = result[2].ToString();
                    textBox7.Text = result[3].ToString();
                    textBox8.Text = result[4].ToString();
                    textBox9.Text = result[5].ToString();
                    textBox10.Text = result[6].ToString();
                }


            }
            catch
            {
                MessageBox.Show("wow much Doge");
            }

            //Maybe some if / loop / array here



        }
    }
}
