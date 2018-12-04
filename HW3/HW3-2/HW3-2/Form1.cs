using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] name = {"張志成","王小美", "董志成", "韓其邁", "咬蚊子", "挖石油" };

            float equheight = 0;
            int[] height = {172, 162, 175, 158, 130, 166 };

            float equweight = 0;
            int[] weight = {68, 52, 63, 44, 32, 70 };

            float equbmi = 0;
            string[] bmi = {"22.99", "19.81", "20.57", "17.63", "18.93", "25.40" };

            //Render
            for (int i = 0; i < 6; i++)
            {
                label2.Text += name[i] + "       ";
                label2.Text += height[i] + "       ";
                label2.Text += weight[i] + "       ";
                label2.Text += bmi[i] + " \n";

                equheight += Convert.ToInt32(height[i]);
                equweight += Convert.ToInt32(weight[i]);
                equbmi += Convert.ToSingle(bmi[i]);


            }

            label3.Text += "   " + equheight/6 + "   " + equweight / 6 + "   " + equbmi/6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
