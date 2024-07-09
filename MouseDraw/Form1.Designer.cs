namespace MouseDraw;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel panelCanvas;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.panelCanvas = new System.Windows.Forms.Panel();
        this.SuspendLayout();
        // 
        // panelCanvas
        // 
        this.panelCanvas.Location = new System.Drawing.Point(12, 12);
        this.panelCanvas.Name = "panelCanvas";
        this.panelCanvas.Size = new System.Drawing.Size(760, 437);
        this.panelCanvas.TabIndex = 0;
        this.panelCanvas.BackColor = System.Drawing.Color.White;
        this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
        this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
        this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(784, 461);
        this.Controls.Add(this.panelCanvas);
        this.Name = "Form1";
        this.Text = "Drawing App";
        this.ResumeLayout(false);
    }
}
