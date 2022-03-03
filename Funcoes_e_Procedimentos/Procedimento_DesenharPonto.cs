public void desenharPonto(PaintEventArgs e, int x, int y, Color cor)
{
    Pen caneta = new Pen(cor, 0);
    e.Graphics.DrawLine(caneta, x, y, x+1, y);
}
