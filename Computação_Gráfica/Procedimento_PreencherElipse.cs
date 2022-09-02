public void preencherElipse(PaintEventArgs e, SolidBrush preenchimento, int Xcentro, int Ycentro, int largura, int altura)
        {
            e.Graphics.FillEllipse(preenchimento, Xcentro, Ycentro, largura, altura);
        }
