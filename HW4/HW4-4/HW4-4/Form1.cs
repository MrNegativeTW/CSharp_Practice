using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] score = new int[] { 90, 100, 80, 60, 30 };

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            for (int i = 0; i <= 4; i++)
            {
                label1.Text = label1.Text + Convert.ToString(score[i]) + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < (4 - i); j++)
                {
                    if (score[j] > score[j + 1])
                    {
                        temp = score[j];
                        score[j] = score[j + 1];
                        score[j + 1] = temp;
                    }
                }
                label2.Text = label2.Text + "第" + Convert.ToString(i + 1) + "排序:";
                for (int k = 0; k <= 4; k++)
                {
                    label2.Text = label2.Text + Convert.ToString(score[k]) + " ";
                }
                label2.Text = label2.Text + "\n";
            }
        }
    }
}
