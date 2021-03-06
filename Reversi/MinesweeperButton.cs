﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    class PictureButtonDemo : System.Windows.Forms.Form
    {
        int clickCount = 0;

        // Create a bitmap object and fill it with the specified color.    
        // To make it look like a custom image, draw an ellipse in it.
        Bitmap MakeBitmap(Color color, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);
            g.DrawEllipse(new Pen(Color.DarkGray), 3, 3, width - 6, height - 6);
            g.Dispose();

            return bmp;
        }

        // Create a new PictureButton control and hook up its properties. 
        public PictureButtonDemo()
        {
            InitializeComponent();

            // Display the OK close button. 
            this.MinimizeBox = false;

            PictureButton button = new PictureButton();
            button.Parent = this;
            button.Bounds = new Rectangle(10, 30, 150, 30);
            button.ForeColor = Color.White;
            button.BackgroundImage = MakeBitmap(Color.Blue, button.Width, button.Height);
            button.PressedImage = MakeBitmap(Color.LightBlue, button.Width, button.Height);
            button.Text = "click me";
            button.Click += new EventHandler(button_Click);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Picture Button Demo";
        }

        static void Main()
        {
            Application.Run(new PictureButtonDemo());
        }

        // Since PictureButton inherits from Control, we can just use the default 
        // Click event that Control supports. 
        private void button_Click(object sender, EventArgs e)
        {
            this.Text = "Click Count = " + ++this.clickCount;
        }
    }

    // This code shows a simple way to have a  
    // button-like control that has a background image. 
    public class PictureButton : Control
    {
        Image backgroundImage, pressedImage;
        bool pressed = false;

        // Property for the background image to be drawn behind the button text. 
        public override Image BackgroundImage
        {
            get
            {
                return this.backgroundImage;
            }
            set
            {
                this.backgroundImage = value;
            }
        }

        // Property for the background image to be drawn behind the button text when 
        // the button is pressed. 
        public Image PressedImage
        {
            get
            {
                return this.pressedImage;
            }
            set
            {
                this.pressedImage = value;
            }
        }

        // When the mouse button is pressed, set the "pressed" flag to true  
        // and invalidate the form to cause a repaint.  The .NET Compact Framework  
        // sets the mouse capture automatically. 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.pressed = true;
            this.Invalidate();
            base.OnMouseDown(e);
        }

        // When the mouse is released, reset the "pressed" flag 
        // and invalidate to redraw the button in the unpressed state. 
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.pressed = false;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        // Override the OnPaint method to draw the background image and the text. 
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.pressed && this.pressedImage != null)
                e.Graphics.DrawImage(this.pressedImage, 0, 0);
            else
                e.Graphics.DrawImage(this.backgroundImage, 0, 0);

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
