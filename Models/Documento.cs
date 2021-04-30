using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeDental.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Cpf { get; set; }
    }
}
