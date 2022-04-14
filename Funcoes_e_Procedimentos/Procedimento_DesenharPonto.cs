public void desenharPonto(PaintEventArgs e, Pen caneta, int x, int y)
{
    e.Graphics.DrawLine(caneta, x, y, x+1, y);
}
