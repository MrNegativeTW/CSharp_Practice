using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] ar = new int[10, 10];
        int[,] ar2 = new int[10, 10];

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ar[i, j] = i + 10 * j;
                    label1.Text += String.Format("{0: 0}", ar[i, j]);
                }
                label1.Text += "\n";
            }

            label2.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ar2[j, 9 - i] = ar[i, j];
                    label2.Text += String.Format("{0: 0}", ar[i, j]);
                }
                label2.Text += "\n";
            }
        }
    }
}
