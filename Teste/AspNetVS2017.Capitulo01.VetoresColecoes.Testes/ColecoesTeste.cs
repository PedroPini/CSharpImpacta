using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTest()
        {
            var inteiros = new List<int>(50) { 2, 1, 2, 6, 125};
            inteiros.Add(22);

            var maisInteiros = new List<int> { 21, 72, 14 };

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 29);

            inteiros.Remove(21);//elemento
            inteiros.RemoveAt(5);//index

            inteiros.Sort();


            //var primeiro = inteiros.First();
            var primeiro = inteiros.FirstOrDefault();
            var ultimo = inteiros[inteiros.Count -1];
            var estahVazia = inteiros.Count == 0;

            /* foreach (var inteiro in inteiros)
             {
                 Console.WriteLine($"{inteiros.IndexOf(inteiro)} : {inteiro}");
             }*/

            for (int i = 0; i < inteiros.Count; i++)
            {
                Console.WriteLine($"{i} : {inteiros[i]}");
            }
            

            
    }
        
    }
}
