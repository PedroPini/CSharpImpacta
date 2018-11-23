using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void ForAninhadoTeste()
        {
            for (int i =0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} é igual a {i * j}");
                }
                Console.WriteLine(new string('-', 50));
            }
        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }

            /*
              *for (1.Inicialização; 2.Condição de execução; 4.Pós-execução)
                {
                    3.Execução;
                }
             * */


        }

        [TestMethod]
        public void ForApenasCondicaoTeste()
        {
            var i = 1;

            for (; i <= 3;)
            {
                Console.WriteLine("i: " + i++);
            }
        }
    }
}
