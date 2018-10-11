using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_3
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        int a = 209000, b = 114850, c = 105980;

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            label3.Text = radioButton1.Text;
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }
    }
}
