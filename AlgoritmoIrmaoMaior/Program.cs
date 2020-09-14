using System;

namespace AlgoritmoIrmaoMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            var IrmaoMaior = new IrmaoMaior();
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite um valor positivo (-1 para finalizar): ");

                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                        break;

                        Console.WriteLine($"Irmao maior: {IrmaoMaior.Obter(n)}");
                }
                catch
                {
                    Console.WriteLine("Valor incorreto");
                }
            }
        }
    }
}
