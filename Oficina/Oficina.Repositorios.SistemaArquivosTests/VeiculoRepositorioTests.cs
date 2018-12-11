using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new Veiculo();

            
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            veiculo.Placa = "PUQ1470";
            veiculo.Observacao = "Carro Placa";
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Cambio =  Cambio.Automatico;
            veiculo.Combustivel = Combustivel.Alcool;
            veiculo.Ano = 2014;
          

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}