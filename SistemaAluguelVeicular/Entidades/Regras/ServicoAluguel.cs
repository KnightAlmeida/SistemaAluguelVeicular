using System;
using SistemaAluguelVeicular.Entidades;

namespace SistemaAluguelVeicular.Entidades.Regras
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        // DEPENDENCIAS

        private IimpostoServico _impostoServico;

        // CONSTRUTORES
        public ServicoAluguel(double precoHora, double precoDia, IimpostoServico impostoServico)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _impostoServico = impostoServico;
        }

        // METODOS

        public void ProcessarFatura(AluguelCarros aluguelCarros)
        {
            TimeSpan duracao = aluguelCarros.Fim.Subtract(aluguelCarros.Inicio);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else {
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _impostoServico.Imposto(pagamentoBasico);


            aluguelCarros.Fatura = new Fatura(pagamentoBasico, imposto);
        }
    }
}
