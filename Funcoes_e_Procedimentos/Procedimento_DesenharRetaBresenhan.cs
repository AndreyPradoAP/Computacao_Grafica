public void desenharRetaBresenham(PaintEventArgs e, Pen caneta, int x0, int y0, int x, int y){
    e.Graphics.DrawLine(caneta, x0, y0, x, y);
}
