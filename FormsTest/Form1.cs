using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void draw(Object obj, PaintEventArgs pea)
        {
            pea.Graphics.DrawEllipse(Pens.Black, this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2 - 50, 100, 100);
        }
    }
}
