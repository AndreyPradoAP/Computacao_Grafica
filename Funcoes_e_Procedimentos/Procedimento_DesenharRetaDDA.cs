public void desenharRetaDDA(PaintEventArgs e, Color cor, int x0, int y0, int x1, int y1)
{
	int distanciaX = x1 - x0;
	int distanciaY = y1 - y0;
	int x = x0;
	int y = y0;
	int espaco = 0;

	if (distanciaX > distanciaY)
		espaco = distanciaX;
	else
		espaco = distanciaY;

	int inclinacaoX = distanciaX / espaco;
	int inclinicaoY = distanciaY / espaco;

	desenharPonto(e, cor, x, y);

	for (int c = 0; c <= espaco; c++)
	{
		x = x + inclinacaoX;
		y = y + inclinicaoY;
		desenharPonto(e, cor, x, y);
	}
}
