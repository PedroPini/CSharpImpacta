<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;
=======
﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
>>>>>>> 1d888ab68fb8a35959bfe8a5eb3d4e478fa3ff1a

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
<<<<<<< HEAD
=======
        const string caminhoArquivo = @"Dados\Cor.txt";

>>>>>>> 1d888ab68fb8a35959bfe8a5eb3d4e478fa3ff1a
        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

<<<<<<< HEAD
            foreach(var item in File.ReadAllLines("Dados\\Cor.txt"))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(item.Substring(0, 5));
                cor.Nome = item.Substring(5);//comeca do parametro 5 que é onde comeca o nome do valor cor EX: 00001|Preto
                cores.Add(cor);
            }
            return cores;
        }
=======
            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }

            return cores;
        }

        public Cor Selecionar(int id)
        {
            //int? x = null;

            Cor cor = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaId = linha.Substring(0, 5);

                if (Convert.ToInt32(linhaId) == id)
                {
                    cor = new Cor();

                    cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                    cor.Nome = linha.Substring(5);
                    //null.ToString();

                    break;
                }
            }

            return cor;
        }
>>>>>>> 1d888ab68fb8a35959bfe8a5eb3d4e478fa3ff1a
    }
}
