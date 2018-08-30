using System;

namespace DIP.Solucao
{
    public class OperacaoB : IOperacao
    {
        public void Executar()
        {
            Console.WriteLine("Foi executada uma ação da OperacaoB");
        }
    }
}
