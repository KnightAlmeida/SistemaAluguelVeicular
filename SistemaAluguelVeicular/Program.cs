using System;
using System.Globalization;
using SistemaAluguelVeicular.Entidades;
using SistemaAluguelVeicular.Entidades.Regras;

namespace SistemaAluguelVeicular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do aluguel");
            Console.Write("Modelo do Carro:");
            string modelo = Console.ReadLine();

            Console.Write("Data e Hora de Escolha (dd/MM/yyyy hh:mm):");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e Hora de Chegada (dd/MM/yyyy hh:mm):");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço da hora: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o preço do dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            AluguelCarros aluguelCarros = new AluguelCarros(inicio, fim, new Veiculo(modelo));
            ServicoAluguel servicoAluguel = new ServicoAluguel(horas, dia, new ImpostoServico());
            servicoAluguel.ProcessarFatura(aluguelCarros);

            Console.WriteLine("FATURA");
            Console.WriteLine(aluguelCarros.Fatura);
        }
    }
}