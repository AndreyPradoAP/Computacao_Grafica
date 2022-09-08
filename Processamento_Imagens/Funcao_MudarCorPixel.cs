public Bitmap mudarCorPixel(Bitmap Imagem, Color cor, int X, int Y)
{
    Imagem.SetPixel(X, Y, cor);

    return Imagem;
}