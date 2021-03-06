﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Core
        int second = 0;

        //For Countdown
        int h = 0, m = 0, s = 0;


        //Start
        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
            timer2.Enabled = false;
            draw();
        }

        //Pause
        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        //Set Time
        private void button3_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            timer2.Enabled = true;
            h = int.Parse(textBox1.Text);
            m = int.Parse(textBox2.Text);
            s = int.Parse(textBox3.Text);
            second = h*3600 + m*60 + s;

            if (second <= 0)
            {
                MessageBox.Show("你媽知道你連時間都會打錯嗎?");
            }
        }

        //Reset
        private void button4_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text = "Time goes here.";
            //Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Positive Timer
        private void timer1_Tick(object sender, EventArgs e) {
           
                second++;
                label1.Text = (second / 3600).ToString() + " 時 " + (second / 60).ToString() + " 分 " + (second % 60).ToString() + " 秒";
            
        }


        //Negative Timer
        private void timer2_Tick(object sender, EventArgs e) {
            second--;
            label1.Text = (second / 3600).ToString() + " 時 " + (second / 60).ToString() + " 分 " + (second % 60).ToString() + " 秒 ";


            if (second <= 0) {
                timer2.Enabled = false;
                label1.Text = "Time's up!";
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        void draw()
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Black), 15, 45, 150, 150);
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90 + 70 - 17, 120));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(90 - 70, 120));

            g.DrawEllipse(new Pen(Color.Black), 225, 45, 150, 150);
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300 + 70 - 17, 120));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(300 - 70, 120));

            g.DrawEllipse(new Pen(Color.Black), 425, 45, 150, 150);
            g.DrawString("0", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500, 120 - 70));
            g.DrawString("15", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500 + 70 - 17, 120));
            g.DrawString("30", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500, 120 + 70 - 17));
            g.DrawString("45", new Font("Times New Roman", 10, FontStyle.Bold | FontStyle.Italic), new SolidBrush(Color.Green), new Point(500 - 70, 120));
        }



    }
}
