using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Classes
{
    public class Multa
    {
        public int idMulta { get; set; }
        public string data_multa { get; set; }
        public int preco_multa { get; set; }
        public string info_multa { get; set; }
        public int id_aluguel { get; set; }
        public Multa()
        {
            idMulta = 0;
            data_multa = "0000-00-00";
            preco_multa = 0;
            info_multa = null;
            id_aluguel = 0;
 
        }



    }
}
