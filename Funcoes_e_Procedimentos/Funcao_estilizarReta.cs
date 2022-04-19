public Pen estilizarLinha(float[] estiloLinha, Color cor, int espessuraReta)
        {
            Pen caneta = new Pen(cor, espessuraReta);
            caneta.DashPattern = estiloLinha;
            return caneta;
        }
