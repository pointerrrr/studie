using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Testing
{
    class MinesweeperButton : ButtonBase
    {
        public MinesweeperButton()
        {
            

            //BackgroundImage;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //pevent.Graphics.FillRectangle(Brushes.Red, 0, 0, 25, 25);
            //pevent.Graphic
            base.OnPaint(pevent);
            
        }

        protected override void OnCreateControl()
        {
            
            base.OnCreateControl();
        }

        protected override void OnMouseHover(EventArgs eventArgs)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Blue, 0, 0, 25, 25);
        }
    }
}
