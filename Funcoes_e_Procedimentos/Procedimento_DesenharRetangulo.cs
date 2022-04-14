public void desenharRetangulo(PaintEventArgs e, Pen caneta, int espessuraReta, int x0, int y0, int largura, int altura)
        {
            e.Graphics.DrawRectangle(caneta, x0, y0, largura, altura);
        }
