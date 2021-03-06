using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Classes
{
    public class Aluguel
    {
        public int IdAluguel { get; set; }
        public int IdCliente { get; set; }
        public int IdVeiculo { get; set; }
        public string NomeCliente { get; set; }
        public string NomeVeiculo { get; set; }
        public int Preco { get; set; }
        public string DataAluguel { get; set; }
        public string DataDevolucao { get; set; }
        public bool Estado { get; set; }

        public Aluguel()
        {
            IdAluguel = 0;
            IdCliente = 0;
            IdVeiculo = 0;
            NomeCliente = "";
            NomeVeiculo = "";
            Preco = 0;
            DataAluguel = "";
            DataDevolucao = "";
            Estado = false;
        }
    }
}
