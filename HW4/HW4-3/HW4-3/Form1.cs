using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] number = new int[] {1,2,3,4,5,6,7,8,9,10 };
        int[] score = new int[10];

        //Generate
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random r = new Random();
            for (int i = 0; i <= 9; i++)
            {
                score[i] = r.Next(0, 101);
                label3.Text = label3.Text + Convert.ToString(number[i]) + " : " + Convert.ToString(score[i]) + "\n";
            }
        }

        //Sort
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            Array.Sort(score, number);
            for (int i = 0; i <= 9; i++)
            {
                label4.Text = label4.Text + Convert.ToString(number[i]) + " : " + Convert.ToString(score[i]) + "\n";
            }
        }
    }
}
