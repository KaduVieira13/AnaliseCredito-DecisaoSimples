using System;

namespace AnaliseCredito_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal valor, rendaFixa, valorDaParcela, valorTotalParcela;
            int parcelas;
            bool valorConvertido, rendaFixaConvertida, parcelasConvertida, aprovacaoCredito;


            Console.WriteLine("--- Análise de Crédito\n");

            Console.Write("Digite o valor desejado: ");
            valorConvertido = Decimal.TryParse(Console.ReadLine(), out valor);

            Console.Write("Digite a quantidade de parcelas: ");
            parcelasConvertida = Int32.TryParse(Console.ReadLine(), out parcelas);

            Console.Write("Digite sua renda mensal: ");
            rendaFixaConvertida = Decimal.TryParse(Console.ReadLine(), out rendaFixa);

            valorDaParcela = valor / parcelas;
            valorTotalParcela = rendaFixa * 30 / 100;
            aprovacaoCredito = valorDaParcela <= valorTotalParcela;

            Console.WriteLine($"O valor da parcela é: {valorDaParcela:C} e o valor máximo permitdo é: {valorTotalParcela:C}.");

            if (!aprovacaoCredito)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Seu crédito não foi aprovado! Valor de parcelas excede a 30% da renda.");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seu crédito foi aprovado!");
                Console.ResetColor();
            }


        }
    }
}
