using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 農夫一次只能帶一樣東西 或 空手過河" + 
                "\n2. 農夫不在時山羊會吃青菜，野狼會吃山羊" +
                "\n3. 3件都過河就過關");
        }
    }
}
