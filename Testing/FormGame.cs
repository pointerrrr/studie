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

            gameContainer1.ResumeLayout(false);
            ClientSize = new Size(size[0]*24 + 21, size[1]*24 + 70);
            Controls.Add(gameContainer1);

        }

        Bitmap MakeBitmap(Color color, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);
            g.DrawEllipse(new Pen(Color.DarkGray), 3, 3, width - 6, height - 6);
            g.Dispose();

            return bmp;
        }
    }
}
