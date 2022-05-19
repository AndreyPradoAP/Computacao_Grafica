public void desenharElipse(PaintEventArgs e, Pen caneta, int Xcentro, int Ycentro, int raiox, int raioy, int anguloInicial, int anguloFinal, Color cor)
        {
            for (int c = anguloInicial; c <= anguloFinal; c++)
            {
                var x = (int)(Xcentro + raiox * Math.Cos(c * Math.PI / 180));
                var y = (int)(Ycentro + raioy * Math.Sin(c * Math.PI / 180));
                desenharPonto(e, caneta, x, y);
            }
        }
