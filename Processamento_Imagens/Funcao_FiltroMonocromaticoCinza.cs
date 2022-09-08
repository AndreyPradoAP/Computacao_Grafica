public Bitmap filtroMonocromaticoCinza(Bitmap imagem)
{
    int[] tamanhoImagem = calcularTamanhoImagem(imagem);

    for (int x = 0; x < tamanhoImagem[0]; x++)
    {
        for (int y = 0; y < tamanhoImagem[1]; y++)
        {
            byte[] rgbPixel = corPixel(imagem, x, y);

            byte tomCinza = (byte)(rgbPixel[0] * 0.3 + rgbPixel[1] * 0.59 + rgbPixel[2] * 0.11);

            Color pixelMonocromatico = corRGB(tomCinza, tomCinza, tomCinza);
            mudarCorPixel(imagem, pixelMonocromatico, x, y);
        }
    }

    return imagem;
}