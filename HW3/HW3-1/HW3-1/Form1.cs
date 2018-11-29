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

        int cash = 0;
        int shopping = 0;
        int change = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cash = Convert.ToInt16(textBox1.Text);
                shopping = Convert.ToInt16(textBox2.Text);
                if (cash < shopping)
                {
                    MessageBox.Show("收現不足");
                }else if (cash > shopping)
                {
                    change = cash - shopping;
                    textBox3.Text = change.ToString();
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
