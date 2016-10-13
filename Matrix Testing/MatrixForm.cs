using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Testing
{
    public partial class MatrixForm : Form
    {
        private Board board;
        int x, y, b, h;

        public MatrixForm()
        {
            InitializeComponent();
            InitializeOwnComponent();
        }

        void InitializeOwnComponent()
        {
            MatrixButton[,] buttonArray = new MatrixButton[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttonArray[i, j] = new MatrixButton();
                    buttonArray[i, j].Location = new Point(26 * i + 2, 26 * j + 2);
                    buttonArray[i, j].Size = new Size(25, 25);
                    buttonArray[i, j].BackgroundImage = MakeBitmap(Color.LightGray, buttonArray[i, j].Width, buttonArray[i, j].Height);
                    buttonArray[i, j].PressedImage = MakeBitmap(Color.Gray, buttonArray[i, j].Width, buttonArray[i, j].Height);
                    buttonArray[i, j].MouseClick += ButtonClicked;
                    buttonArray[i, j].Clickable = true;
                    //boolValues[i, j] = false;
                    //this.Controls.Add(buttonArray[i, j]);
                }
            }
            board = new Board(10, 10, typeof(Button));
            board.Location = new Point(8, 58);
            board.Size = new Size(10 * 26 + 2, 10 * 26 + 2);
            board.ButtonArray = buttonArray;
            Controls.Add(board);
            ClientSize = new Size(board.Size.Width + 20, board.Size.Height + 70);
        }

        private Bitmap MakeBitmap(Color color, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);
            g.Dispose();

            return bmp;
        }

        private void ButtonClicked(Object sender, MouseEventArgs mea)
        {
            if (mea.Button == MouseButtons.Left)
            {
                MatrixButton button = (MatrixButton)sender;
                button.Clickable = false;
                //button.BackgroundImage = MakeBitmap(Color.Red, button.Size.Width, button.Size.Height);
            }
            else if (mea.Button == MouseButtons.Right)
            {
                MatrixButton button = (MatrixButton)sender;
                button.Clickable = true;
                //button.BackgroundImage = MakeBitmap(Color.LightGray, button.Size.Width, button.Size.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTextBoxes();
            MirrorArrayX();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetTextBoxes();
            InvertArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTextBoxes();
            MirrorArrayY();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetTextBoxes();
            TurnArray();
        }

        void InvertArray()
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    board.ButtonArray[x + i, y + j].Clickable = !board.ButtonArray[x + i, y + j].Clickable;
                    board.ButtonArray[x + i, y + j].Invalidate();
                }
            }
        }

        void MirrorArrayX()
        {
            MatrixButton[,] microArray1 = new MatrixButton[b, h];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    microArray1[i, j] = new MatrixButton();
                    microArray1[i, j].Clickable = board.ButtonArray[x + i, y + j].Clickable;
                    //microArray1[i, j].Clickable = true;
                    //boolValues[i, j] = false;
                    //this.Controls.Add(buttonArray[i, j]);
                }
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    board.ButtonArray[x + i, y + j].Clickable = microArray1[b - 1 - i, j].Clickable;
                    board.ButtonArray[x + i, y + j].Invalidate();
                }
            }
        }

        void MirrorArrayY()
        {
            MatrixButton[,] microArray1 = new MatrixButton[b, h];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    microArray1[i, j] = new MatrixButton();
                    microArray1[i, j].Clickable = board.ButtonArray[x + i, y + j].Clickable;
                    //microArray1[i, j].Clickable = true;
                    //boolValues[i, j] = false;
                    //this.Controls.Add(buttonArray[i, j]);
                }
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    board.ButtonArray[x + i, y + j].Clickable = microArray1[b - 1 - i, h - 1 -j].Clickable;
                    board.ButtonArray[x + i, y + j].Invalidate();
                }
            }
        }

        void TurnArray()
        {
            //MirrorArray();
            MatrixButton[,] microArray1 = new MatrixButton[b, h];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    microArray1[i, j] = new MatrixButton();
                    microArray1[i, j].Clickable = board.ButtonArray[i, j].Clickable;
                    board.ButtonArray[i, j].Clickable = true;
                    //board.ButtonArray[i, j].Invalidate();
                    //microArray1[i, j].Clickable = true;
                    //boolValues[i, j] = false;
                    //this.Controls.Add(buttonArray[i, j]);
                }
            }

            int oldB = b, oldH = h;
            b = oldH;
            h = oldB;
            SetTextBoxes();
            //board.Invalidate();

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    board.ButtonArray[x + i, y + j].Clickable = microArray1[j, b - i - 1].Clickable;
                    board.ButtonArray[x + i, y + j].Invalidate();
                }
            }

            
        }

        private void SetTextBoxes()
        {
            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
            textBox3.Text = b.ToString();
            textBox4.Text = h.ToString();
        }

        private void GetTextBoxes()
        {
            x = Int32.Parse(textBox1.Text);
            y = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);
            h = Int32.Parse(textBox4.Text);
            Text = x.ToString() + y.ToString() + b.ToString() + h.ToString();


            //Graphics boardGraphics = board.CreateGraphics();
            //boardGraphics.FillRectangle(Brushes.Blue, x * 24, y * 24, b * 24, l * 24);
            board.Paint += Test;
            board.Invalidate();
        }

        void Test(Object sender, PaintEventArgs pea)
        {
            pea.Graphics.DrawRectangle(Pens.Blue, x * 26 + 1, y * 26 + 1, b * 26, h * 26);
        }
    }
}
