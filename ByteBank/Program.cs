using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            //Metodo();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                try
                {

                    leitor.LerProximaLinha();
                    leitor.LerProximaLinha();


                }
                catch (IOException e)
                {

                    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
                }
                finally
                {
                    leitor.Dispose();
                }
            }


            

        }

        private static void TestaInnerException()
        {
            try

            {
                ContaCorrente conta = new ContaCorrente(5235, 52665);
                ContaCorrente conta2 = new ContaCorrente(5245, 52425);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Transferir(500, conta2);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(ex.InnerException.Message); ;
                Console.WriteLine(ex.InnerException.StackTrace); ;
            }
            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
