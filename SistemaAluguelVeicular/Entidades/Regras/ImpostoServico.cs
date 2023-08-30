namespace SistemaAluguelVeicular.Entidades.Regras
{
    class ImpostoServico : IimpostoServico
    {
        public double Imposto(double valor)
        {
            if (valor <= 100.0)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
