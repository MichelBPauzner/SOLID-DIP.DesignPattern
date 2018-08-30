using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Violacao
{
    public class Executavel
    {
        OperacaoA operacaoA;

        public void ExecutarOperacao(OperacaoA operacao)
        {
            operacaoA = operacao;
            operacaoA.Executar();
        }
    }
}
