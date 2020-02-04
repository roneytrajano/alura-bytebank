using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(7480, 874150);

            try
            {
                Console.WriteLine(ContaCorrente.TaxaOperacao);
            }
            catch (DivideByZeroException)
            {
                //throw;
                Console.WriteLine("deu erro");
            }
            

            Console.ReadLine();
        }

        /*

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }

            //CalcularBonificacao();

            //UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema() 
        {
            Diretor roberta = new Diretor("159.753.398-04");
            SistemaInterno sis = new SistemaInterno();
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("231-312-321-04");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sis.Logar(parceiro, "123456");
            sis.Logar(roberta, "123");
            sis.Logar(camila, "abc");
       
        }

        public static void CalcularBonificacao()
        {
            GerenciarBonificacao gerenciadorBonificacao = new GerenciarBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificacoes no mes " + gerenciadorBonificacao.GetTotalBonificacao());
        }
        */
    }
}
