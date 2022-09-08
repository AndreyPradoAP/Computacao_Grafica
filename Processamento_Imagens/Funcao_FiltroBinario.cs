public Bitmap filtroBinario(Bitmap imagem)
{
    int[] tamanhoImagem = calcularTamanhoImagem(imagem);

    for (int x = 0; x < tamanhoImagem[0]; x++)
    {
        for (int y = 0; y < tamanhoImagem[1]; y++)
        {
            byte[] rgbPixel = corPixel(imagem, x, y);

            if (rgbPixel[0] >= 126)
            {
                Color corPixel = corRGB(255, 255, 255);
                mudarCorPixel(imagem, corPixel, x, y);
            }
            else
            {
                Color corPixel = corRGB(0, 0, 0);
                mudarCorPixel(imagem, corPixel, x, y);
            }
        }
    }

    return imagem;
}