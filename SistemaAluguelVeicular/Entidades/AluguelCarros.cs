namespace SistemaAluguelVeicular.Entidades
{
    class AluguelCarros
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        // CONSTRUTORES
        public AluguelCarros(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }

    }
}
