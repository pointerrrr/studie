using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class FormGame: Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1_MouseMove(sender, e);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button currentButton = (Button) sender;
            if (e.X < 0 || e.X > currentButton.Size.Width || e.Y < 0 || e.Y > currentButton.Size.Height)
            {
                currentButton.Text = "jemoeder";
            }
            else if (e.Button == 0)
            {
                currentButton.Text = "asdf";
            }
            else if (e.Button == MouseButtons.Left)
            {
                currentButton.Text = "fdsa";
            }

        }
    }
}
