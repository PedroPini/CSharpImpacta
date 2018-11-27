using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            foreach(var item in File.ReadAllLines("Dados\\Cor.txt"))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(item.Substring(0, 5));
                cor.Nome = item.Substring(5);//comeca do parametro 5 que é onde comeca o nome do valor cor EX: 00001|Preto
                cores.Add(cor);
            }
            return cores;
        }
    }
}
