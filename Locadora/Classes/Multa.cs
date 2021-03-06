using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Classes
{
    public class Multa
    {
        public Multa()
        {
            idMulta = 0;
            dataMulta = "";
            precoMulta = 0;
            infoMulta = "";
            idAluguel = 0;
        }

        public int idMulta { get; set; }
        public string dataMulta { get; set; }
        public int precoMulta { get; set; }
        public string infoMulta { get; set; }
        public int idAluguel { get; set; }



    }
}
