public void desenharElipseNova(PaintEventArgs e, Pen caneta, int Xcentro, int Ycentro, int largura, int altura)
{
  e.Graphics.DrawEllipse(caneta, Xcentro, Ycentro, largura, altura);
}
