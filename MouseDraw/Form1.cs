namespace MouseDraw;

public partial class Form1 : Form
{
    private bool isDrawing = false;
    private Point lastPoint = Point.Empty;

    public Form1()
    {
        InitializeComponent();
    }

    private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }
    }

    private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDrawing)
        {
            if (lastPoint != null)
            {
                using (Graphics g = panelCanvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }
    }

    private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDrawing = false;
            lastPoint = Point.Empty;
        }
    }
}
