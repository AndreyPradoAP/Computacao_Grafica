public byte[] corPixel(Bitmap imagem, int X, int Y)
{
    byte r = imagem.GetPixel(X, Y).R;
    byte g = imagem.GetPixel(X, Y).G;
    byte b = imagem.GetPixel(X, Y).B;

    byte[] RGB = { r, g, b };

    return RGB;
}