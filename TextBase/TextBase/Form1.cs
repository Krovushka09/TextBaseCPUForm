using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var form = new Form2() { CPU = new CPU() };
            form.ShowDialog(this);
            if (form.flag == 1)
            {
                listBox1.Items.Add(form.CPU);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is CPU)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form3() { Articl = new Articles() };
            form.ShowDialog(this);
            if (form.flag == 1)
            {
                listBox2.Items.Add(form.Articl.Headline);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
