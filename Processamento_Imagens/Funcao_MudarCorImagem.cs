public Bitmap mudarCorImagem(Bitmap Imagem, Color cor, int X, int Y)
{
    Imagem.SetPixel(X, Y, cor);

    return Imagem;
}