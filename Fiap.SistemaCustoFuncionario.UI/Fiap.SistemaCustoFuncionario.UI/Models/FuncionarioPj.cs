using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    class FuncionarioPj : Funcionario
    {
        public decimal ValorHora { get; set; }
        public int QtdeHoras { get; set; }
        public string NrCnpj { get; set; }
    }
}
