using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Repositorios.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repositorios.WebApi.Tests
{
    [TestClass()]
    public class ProductRepositorioTests
    {
        private readonly ProductRepositorio repositorio = new ProductRepositorio();
        [TestMethod()]
        public void PostTest()
        {
            var produtoViewModel = new ProductViewModel();
            produtoViewModel.ProductName = "Televisão";
            produtoViewModel.UnitPrice = 21.57m;
            

            var response = repositorio.Post(produtoViewModel).Result;//retornava uma task com result retorna um resultado do processamento

            Console.WriteLine(response.ProductID);
        }


        [TestMethod]
        public void PutTeste()
        {
            var produtoViewModel = new ProductViewModel();
            produtoViewModel.ProductName = "Televisão Editada";
            produtoViewModel.UnitPrice = 24.57m;
            produtoViewModel.ProductID = 81;

            repositorio.Put(produtoViewModel).Wait();//espera o retorno do banco para prosseguir para as seguintes funcoes

            var response = repositorio.Get(81).Result;//retorna o retorno do processo

            Assert.IsTrue(response.UnitPrice == 24.57m);
            Console.WriteLine(response);
        }

        [TestMethod]
        public void Get()
        {
            var response = repositorio.Get().Result;//espera o retorno do banco para prosseguir para as seguintes funcoes

           //retorna o retorno do processo

            Assert.IsTrue(response.Count > 0);
            Console.WriteLine(response);
        }

        [TestMethod]
        public void Delete()
        {
             repositorio.Delete(81).Wait();//retorna o retorno do processo
            var response = repositorio.Get(81).Result;
            Assert.IsNull(response);
            Console.WriteLine(response);
        }
    }
}