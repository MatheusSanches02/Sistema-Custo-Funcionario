using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    public interface IFuncionario
    {
        public decimal CustoMensal();
        decimal CustoMensal(decimal ferias, decimal decimoTerceiro, decimal fgts, decimal provisaoMulta, decimal previdenciario);
    }
}
