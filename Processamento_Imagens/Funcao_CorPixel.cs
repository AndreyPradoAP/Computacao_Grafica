public Color corPixel(Bitmap imagem, int X, int Y)
{
    int r = imagem.GetPixel(X, Y).R;
    int g = imagem.GetPixel(X, Y).G;
    int b = imagem.GetPixel(X, Y).B;

    Color cor = new Color();
    cor = Color.FromArgb(r, g, b);

    return cor;
}