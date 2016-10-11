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


                        int a, b;
                        a = 25;
                        b = 25;

                        Bitmap backGroundimage = new Bitmap(a, b);
                        Graphics g = Graphics.FromImage(backGroundimage);
                        g.FillRectangle(Brushes.Red, 0, 0, a, b);
                        test[i, j] = new MinesweeperButton
                        {
                            Location = new Point(j * 24, i * 24),
                            Size = new Size(25, 25),
                            
                            TabIndex = 10 * i + j,
                            //FlatStyle = FlatStyle.Flat,
                            TabStop = false,
                            /*BackColor = Color.Gray,
                            ForeColor = Color.Gray,
                            Image = backGroundimage,
                            FlatStyle = FlatStyle.Flat,
                            BackgroundImageLayout = ImageLayout.None,
                            BackgroundImage = BackgroundImage,*/
                            


                        };
                        
                        
                        
                        this.Controls.Add(test[i, j]);
                    }
                }
                
            }
            /*Button blub = new Button();
            blub.Location = new Point(10, 10);
            blub.Size = new Size(100, 100);
            this.Controls.Add(blub);*/
        }
    }
}
