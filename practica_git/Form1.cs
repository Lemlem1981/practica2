namespace practica_git;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Button btn = new Button();
        btn.Text = "Saludar";
        btn.Size = new Size(100,100);
        btn.Location = new Point(
            (ClientSize.Width/2)-(btn.Size.Width/2),
            (ClientSize.Height/2)-(btn.Size.Height/2)
            );
        btn.Click += (s,e) =>
        {
            MessageBox.Show("Hola");
        };
        Controls.Add(btn);

        this.SizeChanged += (s,e) =>
        {
            btn.Location = new Point(
            (ClientSize.Width/2)-(btn.Size.Width/2),
            (ClientSize.Height/2)-(btn.Size.Height/2)
            );
        };
    }
}
