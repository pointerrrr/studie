using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1;
            button1 = new Button();
            button1.Location = new Point(100, 100);
            button1.BackColor = Color.LimeGreen;
            button1.Text = "ASDF";
            this.Controls.Add(button1);
            

            TextBox test;
            test = new TextBox();
            test.Location = new Point(200, 100);
            test.Text = "test";
            button1.Click += new System.EventHandler(this.button1_Click);
            

            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Text);
        }
    }
}
