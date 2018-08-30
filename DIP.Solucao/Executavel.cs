namespace DIP.Solucao
{
    public class Executavel
    {
        IOperacao ope;

        public void ExecutarOperacao(IOperacao operacao)
        {
            ope = operacao;
            ope.Executar();
        }
    }
}
