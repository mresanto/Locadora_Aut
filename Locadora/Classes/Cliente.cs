using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Classes
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public bool Estado{ get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nome = "";
            Cpf = "";
            Cnh = "";
            Estado = false;
        }
        
    }
}
