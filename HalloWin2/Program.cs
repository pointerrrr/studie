using System.Windows.Forms;
using System.Drawing;

class HalloForm : Form
{
    public HalloForm()
    {
        this.Text = "Hallo";
        this.BackColor = Color.Yellow;
        this.Size = new Size(400, 400);

        Label groet;
        groet = new Label();
        groet.Text = "Hallo allemaal";
        groet.Location = new Point(30, 20);
        groet.BackColor = Color.Blue;
        this.Controls.Add(groet);

        Button test;
        test = new Button();
        test.Text = "text";
        test.Location = new Point(100, 100);
        test.BackColor = Color.Green;
        test.ForeColor = Color.Green;
        test.Visible = true;
        test.DialogResult = DialogResult.OK;
        //test.Click += new System.EventHandler(button1_Click);
        this.Controls.Add(test);

        TextBox text;
        text = new TextBox();
        text.Location = new Point(30, 45);
        
        this.Controls.Add(text);

        




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