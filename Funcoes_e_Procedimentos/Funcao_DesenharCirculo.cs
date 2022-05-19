public void desenharCirculo(PaintEventArgs e, Pen caneta, int Xcentro, int Ycentro, int raio, int anguloInicial, int anguloFinal ,Color cor)
        {
            int x = 0;
            int y = 0;

            for (int c = anguloInicial; c >= anguloFinal; c--)
            {
                x = (int) (Xcentro + raio * Math.Cos(c * Math.PI/180));
                y = (int) (Ycentro + raio * Math.Sin(c * Math.PI / 180));
                desenharPonto(e, caneta, x, y);
            }
        }
