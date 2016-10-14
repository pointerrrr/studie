using System.Drawing;
using System.Windows.Forms;

namespace Matrix_Testing
{
    class MatrixButton : Control
    {
        public MatrixButton()
        {
            DoubleBuffered = true;
        }

        Image _backgroundImage, _pressedImage;
        bool _pressed = false, _canClick = true;

        // Property for the background image to be drawn behind the button text. 
        public override Image BackgroundImage
        {
            get { return this._backgroundImage; }
            set { this._backgroundImage = value; }
        }

        // Property for the background image to be drawn behind the button text when 
        // the button is pressed. 
        public Image PressedImage
        {
            get { return this._pressedImage; }
            set { this._pressedImage = value; }
        }

        public bool Clickable
        {
            get { return this._canClick; }
            set { this._canClick = value; }
        }

        public bool Pressed
        {
            get { return this._pressed; }
            set { this._pressed = value; this.Invalidate();}
        }

        // When the mouse button is pressed, set the "pressed" flag to true  
        // and invalidate the form to cause a repaint.  The .NET Compact Framework  
        // sets the mouse capture automatically. 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Clickable)
                {
                    this._pressed = true;
                    this.Invalidate();
                    base.OnMouseDown(e);
                }
            }
            
        }



        private Bitmap MakeBitmap(Color color, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);
            g.Dispose();

            return bmp;
        }

        // When the mouse is released, reset the "pressed" flag 
        // and invalidate to redraw the button in the unpressed state. 
        protected override void OnMouseUp(MouseEventArgs e)
        {

            this._pressed = false;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        // Override the OnPaint method to draw the background image and the text. 
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this._pressed && this._pressedImage != null)
                e.Graphics.DrawImage(this._pressedImage, 0, 0);
            else if (!Clickable)
            {
                e.Graphics.DrawImage(MakeBitmap(Color.Red, Width, Height), 0 , 0);
            }
            else
                e.Graphics.DrawImage(this._backgroundImage, 0, 0);

            // Draw the text if there is any. 
            if (this.Text.Length > 0)
            {
                SizeF size = e.Graphics.MeasureString(this.Text, this.Font);

                // Center the text inside the client area of the PictureButton.
                e.Graphics.DrawString(this.Text,
                    this.Font,
                    new SolidBrush(this.ForeColor),
                    (this.ClientSize.Width - size.Width) / 2,
                    (this.ClientSize.Height - size.Height) / 2);
            }

            // Draw a border around the outside of the  
            // control to look like Pocket PC buttons.
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0,
                this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            base.OnPaint(e);
        }
    }
}
