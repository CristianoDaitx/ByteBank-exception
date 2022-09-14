using System;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
