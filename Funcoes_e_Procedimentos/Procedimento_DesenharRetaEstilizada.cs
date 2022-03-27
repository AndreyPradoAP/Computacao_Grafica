public void desenharRetaEstilizada(PaintEventArgs e, float[] estiloLinha, Color cor, int espessuraReta, int x0, int y0, int x, int y)
        {
            Pen caneta = new Pen(cor, espessuraReta);
            caneta.DashPattern = estiloLinha;
            e.Graphics.DrawLine(caneta, x0, y0, x, y);
        }
