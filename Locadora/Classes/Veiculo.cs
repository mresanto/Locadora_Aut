using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Classes
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Info { get; set; }
        public bool Dis { get; set; }

        public Veiculo()
        {
            IdVeiculo = 0;
            Nome = "";
            Cor = "";
            Info = "";
            Dis = false;
        }

        


    }
}
