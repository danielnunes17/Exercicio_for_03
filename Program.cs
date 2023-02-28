/*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2,
o segundo valor tem peso 3 e o terceiro valor tem peso 5.
 
Entrada:                                        Saida: 5.7, 6.3, 9.3
3
6.5 4.3 6.2
5.1 4.2 8.1
8.0 9.0 10.0
 */

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite 3 números em sequencia: ");
            string[] linha = Console.ReadLine().Split(' ');

            double a = double.Parse(linha[0], CultureInfo.InvariantCulture);
            double b = double.Parse(linha[1], CultureInfo.InvariantCulture);
            double c = double.Parse(linha[2], CultureInfo.InvariantCulture);

            double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            break;
        }
    }
}