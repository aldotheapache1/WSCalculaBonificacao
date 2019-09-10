using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCalculaBonificacao.Models
{
    public class Valores
    {
        public double salario { get; set; }
        public int qtdFaltas { get; set; }
        public int qtdAdvertencias { get; set; }
        public int produtividade { get; set; }
        public int qtdHorasCursos { get; set; }
        public double resultado { get; set; }
    }
}