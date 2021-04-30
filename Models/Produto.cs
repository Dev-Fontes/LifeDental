using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
