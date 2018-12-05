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

namespace HW3_4 {
    public partial class Form1 : Form {

        public Form1() { InitializeComponent(); }

        //List of Item to sale.
        ArrayList namee = new ArrayList();
        ArrayList costt = new ArrayList();
        ArrayList pricee = new ArrayList();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < namee.Count; i++) {
                if (comboBox1.Text == namee[i].ToString()) {
                    textBox1.Text = costt[i].ToString();
                    textBox2.Text = pricee[i].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!namee.Contains(comboBox1.Text)) {
                //Add new item to list.
                namee.Add(comboBox1.Text);
                costt.Add(textBox1.Text);
                pricee.Add(textBox2.Text);
                MessageBox.Show("Item Added.");
            } else if (namee.Contains(comboBox1.Text)) {
                for (int a = 0; a < namee.Count; a++) {
                    //remove old name or price by user select, then rewrite it with new name or price.
                    namee.RemoveAt(a);
                    namee.Insert(a, comboBox1.Text);
                    costt.RemoveAt(a);
                    costt.Insert(a, textBox1.Text);
                    pricee.RemoveAt(a);
                    pricee.Insert(a, textBox2.Text);
                    MessageBox.Show("Update.");

                    //Prevent rewrite all item because of for loop.
                    break;
                }
            }

            //Clean combobox item, then add new item.
            comboBox1.Items.Clear();
            foreach (string names in namee) {
                comboBox1.Items.Add(names);
            }
        }
    }
}
