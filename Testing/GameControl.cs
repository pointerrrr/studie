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
    public class GameControl : Control
    {
        public GameControl(int widht, int heigth, Type type)
        {
            
            
            if (type == typeof(MinesweeperButton))
            {
                MinesweeperButton[,] test = new MinesweeperButton[widht, heigth];
                for (int i = 0; i < widht; i ++)
                {
                    for (int j = 0; j < heigth; j++)
                    {
                        test[i, j] = new MinesweeperButton();
                        test[i, j].Location = new Point(24 * i, 24 * j);
                        test[i, j].Size = new Size(25, 25);
                        test[i, j].BackgroundImage = MakeBitmap(Color.LightGray, test[i, j].Width, test[i, j].Height);
                        test[i, j].PressedImage = MakeBitmap(Color.Gray, test[i, j].Width, test[i, j].Height);
                        this.Controls.Add(test[i, j]);
                    }
                }
                
            }
        }

        Bitmap MakeBitmap(Color color, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);
            g.Dispose();

            return bmp;
        }
    }
}
