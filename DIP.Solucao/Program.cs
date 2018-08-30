using System;

namespace DIP.Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            Executavel executavel = new Executavel();
            OperacaoA operacaoA = new OperacaoA();
            executavel.ExecutarOperacao(operacaoA);

            OperacaoB operacaoB = new OperacaoB();
            executavel.ExecutarOperacao(operacaoB);

            Console.ReadKey();
        }
    }
}
