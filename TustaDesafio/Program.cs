using System;

namespace TustaDesafio
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declarações de variáveis
            float valorMonetario;
            int numeroParcelas;

            // primeiro input do valor monetário
            Console.Write("Digite um valor em R$ ");
            valorMonetario = float.Parse(Console.ReadLine());

            // segundo input contendo o número de parcelas
            Console.Write("Digite o número de parcelas: ");
            numeroParcelas = int.Parse(Console.ReadLine());

            CalculaParcelas(valorMonetario, numeroParcelas);
        }

        public static float CalculaParcelas(float valorMonetario, int numeroParcelas)
        {
            // valor de cada parcela
            float valorParcelas = valorMonetario / numeroParcelas;

            // loop para apresentar os valores das parcelas
            for (int parcela = 1; parcela <= numeroParcelas; parcela++)
            {
                Console.WriteLine($"A {parcela}º parcela é de {valorParcelas:C}");
            }

            return valorParcelas;
        }
    }
}
