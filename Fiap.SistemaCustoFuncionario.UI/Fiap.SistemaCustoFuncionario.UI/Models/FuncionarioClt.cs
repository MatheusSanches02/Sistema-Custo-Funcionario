using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    class FuncionarioClt : Funcionario
    {
        public decimal Salario { get; set; }
        public bool CargoConfiança { get; set; }
    }
}
