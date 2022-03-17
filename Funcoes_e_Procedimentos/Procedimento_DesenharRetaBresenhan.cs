public void desenharretaBresenham(PaintEventArgs e, Color cor, int x0, int y0, int x, int y){
    Pen caneta = new Pen(cor, 0);
    e.Graphics.DrawLine(caneta, x0, y0, x, y);
}
