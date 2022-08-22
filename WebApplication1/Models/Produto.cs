using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public long? DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public double Valor { get; set; }
    }
}