public void desenharRetangulo(PaintEventArgs e, Color cor, int espessuraReta, int x0, int y0, int largura, int altura)
        {
            Pen caneta = new Pen(cor, espessuraReta);
            e.Graphics.DrawRectangle(caneta, x0, y0, largura, altura);
        }
