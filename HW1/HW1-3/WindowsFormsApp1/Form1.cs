using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
        //BMI計算公式為體重(kg)/身高(m2)，範例為身高150公分，體重54公斤時，BMI=54/(1.5)2 ，結果為24

        private void button1_Click(object sender, EventArgs e)
        {
            //轉換數值型態
            float h = float.Parse(textBox1.Text);
            float w= float.Parse(textBox2.Text);
            float r;

            //計算
            r = w / (h * h);

            //轉換結果數值型態
            string rr;
            rr = r.ToString();

            //判斷為過瘦正常肥胖等等
            if (r <= 18.5) {
                label3.Text = "你太瘦, BMI 為" + rr;
                label3.ForeColor = Color.Red;
            }
            else if(r >= 18.5 && r <24) {
                label3.Text = "正常, BMI 為" +  rr;
                label3.ForeColor = Color.LimeGreen;
            }
            else if (r >= 24 && r < 27)
            {
                label3.Text = "過重, BMI 為" +  rr ;
                label3.ForeColor = Color.Red;
            }
            else if (r >= 27 && r < 30)
            {
                label3.Text = "輕度肥胖, BMI 為" + rr;
                label3.ForeColor = Color.Red;
            }
            else if (r >= 30 && r < 35)
            {
                label3.Text = "中度肥胖, BMI 為" + rr;
                label3.ForeColor = Color.Red;
            }
            else if (r > 35)
            {
                label3.Text = "重度肥胖, BMI 為" + rr;
                label3.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "BMI";
            label3.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //用按鈕關閉程式
            this.Close();
        }
    }
}
