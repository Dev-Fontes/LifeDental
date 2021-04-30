using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Credito { get; set; }
    }
}
