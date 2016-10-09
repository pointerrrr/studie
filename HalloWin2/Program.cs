using System.Windows.Forms;
using System.Drawing;
using System;

class Roos : Form
{
    int aantal = 1;
    int x, y;
    public Roos()
    {
        this.Text = "Roos";
        x = this.ClientSize.Width / 2;
        y = this.ClientSize.Height / 2;
        this.Paint += this.tekenScherm;
    }

    void tekenScherm(Object obj, PaintEventArgs pea)
    {
        Button meer = new Button();
        meer.Location = new Point(10, 10);
        meer.Size = new Size(60, 30);
        meer.Text = "Meer";
        this.Controls.Add(meer);
        meer.Click += new System.EventHandler(this.meer_Clicked);
        this.Paint += generateRoos;
        this.MouseClick += klik;
    }

    void klik(Object obj, MouseEventArgs mea)
    {
        x = mea.X;
        y = mea.Y;
        this.Invalidate();
    }

    void meer_Clicked(Object obj, EventArgs ea)
    { aantal++; this.Invalidate(); }

    void generateRoos(Object obj, PaintEventArgs pea)
    {
        for (int t = 0; t < aantal; t++)
        {
            int r = 5 + t * 10;
            pea.Graphics.DrawEllipse(Pens.Black, x - r, y - r, r * 2, r * 2);
        }
    }

}

class HalloWin2
{
    static void Main()
    {
        Roos scherm;
        scherm = new Roos();
        Application.Run(scherm);
        
    }
}