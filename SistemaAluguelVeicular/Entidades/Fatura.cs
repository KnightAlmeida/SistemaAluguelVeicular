using System.Globalization;

namespace SistemaAluguelVeicular.Entidades
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Imposto; }
        }

        // TOSTRING

        public override string ToString()
        {
            return "Pagamento Básico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
            + "\nImposto " + Imposto.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento Total: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
