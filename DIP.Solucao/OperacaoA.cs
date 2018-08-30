using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Solucao
{
    public class OperacaoA : IOperacao
    {
        public void Executar()
        {
            Console.WriteLine("Foi executada uma ação da OperacaoA");
        }
    }
}
