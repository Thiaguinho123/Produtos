using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Departamento
    {
        public long DepartamentoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Departamento> Departamanetos { get; set; }
    }
}