using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.ENT
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Ordem { get; set; }
        public DateTime? InicioFerias { get; set; }
        public DateTime? Fimferias { get; set; }
    }
}
