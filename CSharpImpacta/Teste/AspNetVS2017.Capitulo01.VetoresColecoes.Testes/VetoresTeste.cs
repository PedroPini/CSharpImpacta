using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];
            strings[0] = "AA";


            var decimais = new decimal[] { 0.5m, 78, 1, 1.59m};

            foreach (var @decimal in decimais)
            {
                Console.WriteLine($"Valor Decimal: {@decimal}");
            }

            Console.WriteLine($"Tamanho do vetor {decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 78, 1, 1.59m };

            Array.Resize(ref decimais, 6);
            decimais[5] = 20.01m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 78, 1, 1.59m };

            Array.Sort(decimais); //Reajanja na ordem correta

            Assert.AreEqual(decimais[0], 0.5m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var notas = new decimal[] { 0.5m, 78, 1, 1.59m };
            Console.WriteLine(ObterMedia(notas));
            Console.WriteLine(ObterMedia(2, 8, 2.9m, 4.23m));
        }
       
        public decimal ObterMedia(params decimal[] notas)
        {
            decimal resultado = 0;
            foreach (var nota in notas)
            {
                resultado += nota; 
            }
            return resultado/ notas.Length;
            
            //alternativa decimais.Average();
        }

        public void TodaStringEhUmVetorTeste()
        {
            const string nome = "Hejlsberg";

            Assert.AreEqual(nome[0], 'H');

            foreach (var @char in nome)
            {
                Console.WriteLine(@char);            }
        }

    }
}
