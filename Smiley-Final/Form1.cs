using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiley_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            ColorDialog SmileColor = new ColorDialog();
            SmileColor.Color = textBox3.ForeColor;
            if (SmileColor.ShowDialog() == DialogResult.OK)
                textBox3.BackColor = SmileColor.Color;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            ColorDialog SmileColor = new ColorDialog();
            SmileColor.Color = textBox4.ForeColor;
            if (SmileColor.ShowDialog() == DialogResult.OK)
                textBox4.BackColor = SmileColor.Color;
        }


        private void textBox5_Click(object sender, EventArgs e)
        {
            ColorDialog SmileColor = new ColorDialog();
            SmileColor.Color = textBox5.ForeColor;
            if (SmileColor.ShowDialog() == DialogResult.OK)
                textBox5.BackColor = SmileColor.Color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size, happiness;
            Color smiley, eyes, mouth;
            size = trackBar1.Value * 10;
            happiness = trackBar2.Value;
            smiley = textBox3.BackColor;
            eyes = textBox4.BackColor;
            mouth = textBox5.BackColor;

            //SmileyForm scherm;
            //scherm = new SmileyForm;


        }
    }
}
