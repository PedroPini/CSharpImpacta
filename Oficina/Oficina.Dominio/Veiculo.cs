using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Veiculo
    {
<<<<<<< HEAD
        public int Id { get; set; }
=======
        /*
        public Veiculo()
        {
            Id = Guid.NewGuid();
        } OU
        */
        public Guid Id { get; set; } = Guid.NewGuid();
>>>>>>> 1d888ab68fb8a35959bfe8a5eb3d4e478fa3ff1a
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
    }
}
