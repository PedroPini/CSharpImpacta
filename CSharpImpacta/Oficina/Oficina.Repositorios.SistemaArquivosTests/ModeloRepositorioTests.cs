using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void SelecionarTest(int marcaId)
        {
            var modelos = modeloRepositorio.SelecionarPorMarca(marcaId);
            foreach (var item in modelos)
            {
                Console.WriteLine($"Id: {item.Id}, Marca Id e Nome: {item.Marca.Id}, {item.Marca.Nome}, Modelo: {item.Nome}");
            }
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void Selecionar(int modeloId)
        {
            Assert.IsTrue(new ModeloRepositorio().Selecionar(1).Nome == "Fox");
            var modelo = modeloRepositorio.Selecionar(modeloId);
            Console.WriteLine($"Nome: {modelo.Nome}, Marca: {modelo.Marca.Nome}, Id: {modelo.Id}");
        }
    }
}