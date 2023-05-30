using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringNormalizer
{
    public partial class StringNormalizer : Form
    {
        public StringNormalizer()
        {
            InitializeComponent();
        }

        public static string first = "Please, insert the string here";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           first = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            English En = new English();
            textBox2.Text = En.Engl();
            Clipboard.SetData(DataFormats.Text, (Object)textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Russian Rusi = new Russian();
            textBox2.Text = Rusi.Rus();
            Clipboard.SetData(DataFormats.Text, (Object)textBox2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
             Author Au = new Author();
             textBox2.Text = Au.Auth();
            Clipboard.SetData(DataFormats.Text, (Object)textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)    //Clear button
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Summary Sum = new Summary();
            textBox2.Text = Sum.Sum();
            Clipboard.SetData(DataFormats.Text, (Object)textBox2.Text);
        }
    }
}
