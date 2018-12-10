using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Select Border or not
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            /* Change Form Border
            if (comboBox1.Text == "Normal") {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
            else if (comboBox1.Text == "Borderless") {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            */
        }

        //Donate Button
        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Demo");
            System.Diagnostics.Process.Start("https://www.organicsoupkitchen.org/donate");
        }

        //Game Start Button
        int money = 0;
        private void button2_Click(object sender, EventArgs e) {

            /*
             * Source : https://dotblogs.com.tw/yc421206/archive/2010/08/10/17108.aspx
             */

            //Init XML
            XmlDocument doc = new XmlDocument();
            XmlElement Settings = doc.CreateElement("Settings");
            doc.AppendChild(Settings);

            /*
             * Create Child Node - Window Mode
             */
            XmlElement Window = doc.CreateElement("Window");
            //設定屬性
            if (comboBox1.Text == "Normal") {
                Window.SetAttribute("value", "normal");
            } else if (comboBox1.Text == "Borderless") {
                Window.SetAttribute("value", "borderLess");
            }
            //加入至 Window 節點底下
            Settings.AppendChild(Window);


            /*
             * Create Child Node - Backgroung Color Change or Not
             */
            XmlElement BackColor = doc.CreateElement("BackColor");
            //設定屬性
            if (comboBox2.Text == "Enable") {
                BackColor.SetAttribute("value", "Enable");
            } else if (comboBox2.Text == "Disable") {
                BackColor.SetAttribute("value", "Disable");
            }
            //加入至 BackColor 節點底下
            Settings.AppendChild(BackColor);


            /*
             * Create Child Node - Money
             */
            XmlElement Money = doc.CreateElement("Money");
            //設定屬性

            //Check Number
            try {
                money = Convert.ToInt32(textBox1.Text);
            } catch {
                MessageBox.Show("請輸入正確的數字，謝謝惠顧。");
            }
            Money.SetAttribute("value", textBox1.Text);

            //加入至 BackColor 節點底下
            Settings.AppendChild(Money);

            //存檔
            doc.Save("Test.xml");




           
        }

        // Quit Button
        private void button3_Click(object sender, EventArgs e) { this.Dispose(); }

        //Cover Pic
        private void timer1_Tick(object sender, EventArgs e) {
            //Release Memory
            pictureBox1.Image.Dispose();
            pictureBox1.Image = Properties.Resources.Radeon_VR_Ready;
        }

        //Cover Pic
        private void timer2_Tick(object sender, EventArgs e) {
            //Release Memory
            pictureBox1.Image.Dispose();
            pictureBox1.Image = Properties.Resources.GeForce_RTX_01;
        }

        
    }
}
