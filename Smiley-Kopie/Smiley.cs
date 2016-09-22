using System.Windows.Forms;
using System.Drawing;

class SmileyForm : Form
{
    public SmileyForm(int size, int happiness)
    {
        this.Text = "Hallo";
        this.BackColor = Color.Black;
        this.Size = new Size(size + 16, size + 39);
        this.Paint += this.tekenScherm;
        //int test = happiness;
    }

    public int[] SmileySize() {
        int size = 200;
        int happiness= 40;
        int[] test = { size, happiness };
        return test;

    }

    void tekenScherm(object obj, PaintEventArgs pea)
    {
        int size = this.Size.Width - 16; 
        Brush smiley = new SolidBrush(Color.Yellow);
        Rectangle smileyRect = new Rectangle(size / 8, size / 8, size / 4 *3, size / 4 * 3);
        Brush eyes = new SolidBrush(Color.Black);
        Pen smile = new Pen(Color.Black, 5);
        float startAngle = 0.0F;
        float sweepAngle = 180.0F;
        Rectangle smileBox = new Rectangle(size / 3, size / 2, size / 2, size / 4);
        Rectangle eyesRectLeft = new Rectangle(size / 4, size / 4, size / 8, size / 8);
        Rectangle eyesRectRight = new Rectangle(size - (size / 2 - size / 8), size / 4, size / 8, size / 8);
        //Rectangle smileyRect = new Rectangle(50, 50, 300, 300);
        pea.Graphics.FillEllipse(smiley, smileyRect);
        pea.Graphics.FillEllipse(eyes, eyesRectLeft);
        pea.Graphics.FillEllipse(eyes, eyesRectRight);
        pea.Graphics.DrawArc(smile, smileBox, startAngle, sweepAngle);
        pea.Graphics.DrawRectangle(new Pen(Color.LightGreen, 2), smileBox);
    }
}

class Smiley
{
    public static void Main()
    {
        int size = 200;
        int happiness = 40;
        //int test123;
        Point locatie = new Point(100, 100);
        Color eyes = Color.Black;
        Color smiley = Color.Yellow;
        SmileyForm scherm;
        scherm = new SmileyForm(size, happiness);
        Application.Run(scherm);
    }
}