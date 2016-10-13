using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Matrix_Testing
{
    class Board : UserControl
    {
        private int _width, _heigth;
        private MatrixButton[,] buttonArray;

        public Board(int width, int heigth, Type type)
        {
            DoubleBuffered = true;
            _width = width;
            _heigth = heigth;
            //MinesweeperButton[,] buttonArray = generateArray(width, heigth);
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        protected override void OnCreateControl()
        {
            for (int i = 0; i < ButtonArray.GetLength(0); i++)
            {
                for (int j = 0; j < ButtonArray.GetLength(1); j++)
                {
                    Controls.Add(ButtonArray[i, j]);
                }
            }
            base.OnCreateControl();
        }

        public MatrixButton[,] ButtonArray
        {
            get { return buttonArray; }
            set { buttonArray = value; }
        }
    }
}
