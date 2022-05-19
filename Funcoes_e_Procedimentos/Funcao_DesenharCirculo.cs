/*
        Tá em sentido horário
*/


public void desenharCirculo(PaintEventArgs e, Pen caneta, int Xcentro, int Ycentro, int raio, int anguloInicial, int anguloFinal ,Color cor)
        {
            for (int c = anguloInicial; c <= anguloFinal; c++)
            {
                var x = (int) (Xcentro + raio * Math.Cos(c * Math.PI / 180));
                var y = (int) (Ycentro + raio * Math.Sin(c * Math.PI / 180));
                desenharPonto(e, caneta, x, y);
            }
        }
