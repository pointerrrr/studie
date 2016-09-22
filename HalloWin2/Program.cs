using System.Windows.Forms;
using System.Drawing;

class HalloForm : Form
{
    public HalloForm()
    {
        this.Paint += this.tekenScherm;
    }

    public void tekenScherm(object o, PaintEventArgs pea)
    {
        Graphics g = pea.Graphics;
        tekenKruis(pea, 10, 10, Pens.Black);
        tekenKruis(pea, 20, 30, Pens.Red);
        tekenKruis(pea, 30, 60, Pens.Blue);
    }

    public void tekenKruis(PaintEventArgs pea, int size, int location, Pen pen)
    {
        
        Graphics g = pea.Graphics;        g.DrawLine(pen, location, 10, location + size, size + 10);
        g.DrawLine(pen, location + size, 10, location, size + 10);
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // HalloForm
        // 
        this.ClientSize = new System.Drawing.Size(278, 244);
        this.Name = "HalloForm";
        this.ResumeLayout(false);

        

    }
}

class HalloWin2
{
    static void Main()
    {
        HalloForm scherm;
        scherm = new HalloForm();
        Application.Run(scherm);
        
    }
}