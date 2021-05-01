using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public Cliente cliente { get; set; }
        public Produto produto { get; set; }


    }

}
