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
    public partial class FormGame : Form
    {
        private GameControl gameContainer1;
        //private GameControl asdf;
        public FormGame()
        {
            InitializeComponent();
            InitializeOwnComponents();
        }

        private void InitializeOwnComponents()
        {
            int[] size = {10, 10};
            gameContainer1 = new GameControl(size[0], size[1], typeof(MinesweeperButton))
            {
                Location = new Point(10, 60),
                Name = "gameContainer1",
                Size = new Size(size[0]*24 + 1, size[1]*24 + 1),
                TabIndex = 0,
                TabStop = false,
                
            };
            gameContainer1.MouseHover += gameContainer1_MouseHover;
            gameContainer1.ResumeLayout(false);
            ClientSize = new Size(size[0]*24 + 21, size[1]*24 + 70);
            Controls.Add(gameContainer1);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1_MouseMove(sender, e);
        }

        private void gameContainer1_MouseHover(Object sender, EventArgs ea)
        {
            Button testing;
            Point e = MousePosition;
            testing = (Button)GetChildAtPoint(PointToClient(new Point(e.X, e.Y)));
            //testing.MouseMove += button1_MouseMove;
            testing.Text = "a";
            
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
