using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HW3_3
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        ArrayList left = new ArrayList();
        ArrayList right = new ArrayList();


        public void Form1_Load(object sender, EventArgs e)
        {
            Init_Self();
        }
        
        

        //Help Button
        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "1. 農夫一次只能帶一樣東西 或 空手過河" +
                "\n2. 農夫不在時山羊會吃青菜，野狼會吃山羊" +
                "\n3. 3件都過河就過關", "Rules");
        }

        //Move to right
        private void button2_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Nothing...");
            } else if (
                        listBox1.SelectedItem.ToString() == "山羊" || 
                        listBox1.SelectedItem.ToString() == "野狼" || 
                        listBox1.SelectedItem.ToString() == "青菜" ) {
                right.Add(listBox1.SelectedItem);
                left.Remove(listBox1.SelectedItem);
                right.Add("農夫");
                left.Remove("農夫");
                Add_Item();
            } else if (listBox1.SelectedItem.ToString() == "農夫") {
                right.Add("農夫");
                left.Remove("農夫");
                Add_Item();
            }

            Check_Gameover();
        }

        //Move to Left
        private void button3_Click(object sender, EventArgs e) {
            if (listBox2.SelectedIndex == -1) {
                MessageBox.Show("Nothing...");
            } else if (
                        listBox2.SelectedItem.ToString() == "山羊" ||
                        listBox2.SelectedItem.ToString() == "野狼" ||
                        listBox2.SelectedItem.ToString() == "青菜") {
                left.Add(listBox2.SelectedItem);
                right.Remove(listBox2.SelectedItem);
                left.Add("農夫");
                right.Remove("農夫");
                Add_Item();
            } else if (listBox2.SelectedItem.ToString() == "農夫") {
                left.Add("農夫");
                right.Remove("農夫");
                Add_Item();
            }

            Check_Gameover();
        }

        // Check Gameover Rules = True
        public void Check_Gameover() {
            if (left.Contains("山羊") && left.Contains("青菜") && !left.Contains("農夫")) {
                MessageBox.Show("您已被開除，山羊吃了青菜");
                Init_Self();
            }
            if (right.Contains("山羊") && right.Contains("青菜") && !right.Contains("農夫")) {
                MessageBox.Show("您已被開除，山羊吃了青菜");
                Init_Self();
            }
            if (left.Contains("山羊") && left.Contains("野狼") && !left.Contains("農夫")) {
                MessageBox.Show("您已被開除，山羊嚇跑了野狼");
                Init_Self();
            }
            if (right.Contains("山羊") && right.Contains("野狼") && !right.Contains("農夫")) {
                MessageBox.Show("您已被開除，山羊嚇跑了野狼");
                Init_Self();
            }
            if (left.Count > 0) {}else {
                MessageBox.Show("wow! You just did it!");
            }
        }

        
        public void Init_Self()
        {
            left.Clear();
            right.Clear();
            left.Add("青菜");
            left.Add("山羊");
            left.Add("野狼");
            left.Add("農夫");
            Add_Item();
        }
        
        //Update listbox item
        public void Add_Item()
        {
            try {
                // Left Side
                listBox1.Items.Clear();
                foreach (string leftt in left)
                {
                    listBox1.Items.Add(leftt);
                }

                // Right Side
                listBox2.Items.Clear();
                foreach (string rightt in right)
                {
                    listBox2.Items.Add(rightt);
                }
            }
            catch {
                MessageBox.Show("Something just happend, but I won't tell you.");
            }
            
        }
    }
}
