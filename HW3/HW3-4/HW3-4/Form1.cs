using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] name = { "舒跑", "德意的一天 健康猶"};
        int[] cost = { 21, 55 };
        int[] price = { 25, 8999 };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string names in name) {
                comboBox1.Items.Add(names);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < name.Length; i++) {
                if (comboBox1.Text == name[i]) {
                    textBox1.Text = cost[i].ToString();
                    textBox2.Text = price[i].ToString();
                }
            }
            //Test Select Text
            //label1.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < name.Length; i++) {
                if (comboBox1.Text == name[i])
                {
                    cost[i] = Convert.ToInt32(textBox1.Text);
                    price[i] = Convert.ToInt32(textBox2.Text);
                    MessageBox.Show("資料已更新...");
                }
            }
        }
    }
}
