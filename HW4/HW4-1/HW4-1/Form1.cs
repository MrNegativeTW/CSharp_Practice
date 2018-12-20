using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] cost = new int[,] { { 390, 350, 0, 380, 380 }, { 290, 300, 0, 300, 320 }, { 0, 700, 700, 680, 0 }, { 0, 480, 420, 480, 0 } };
            int end_cost;
            end_cost = cost[comboBox1.SelectedIndex, comboBox2.SelectedIndex];
            if (end_cost != 0)
            {
                MessageBox.Show("你選的是:" + comboBox2.SelectedItem + comboBox1.SelectedItem +"Price : "+ Convert.ToString(end_cost));
            }
            else
            {
                MessageBox.Show("你選的是:" + comboBox2.SelectedItem + comboBox1.SelectedItem + "\n缺貨啦幹");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] clothing = new string[] {"圓領毛衣", "Polo 山","兩件式上衣","長外套"};
            string[] color = new string[] {"Purple","White","P!nk","Light Blue", "Just Black" };
            for (int i = 0; i <= clothing.GetUpperBound(0); i++)
            {
                comboBox1.Items.Add(clothing[i]);
            }
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i <= color.GetUpperBound(0); i++)
            {
                comboBox2.Items.Add(color[i]);
            }
            comboBox2.SelectedIndex = 0;
        }
    }
}
