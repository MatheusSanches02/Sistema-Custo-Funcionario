using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    internal class FuncionarioClt : Funcionario
    {
        public decimal Salario { get; set; }
        public bool CargoConfiança { get; set; }

        public FuncionarioClt()
        {
        }

        public FuncionarioClt(decimal salario)
        {
            Salario = salario;
        }

        public FuncionarioClt(TipoFuncionario tipo, int codigoRegistro, string nome, string genero, decimal salario, bool cargoConfiança) : base(tipo, codigoRegistro, nome, genero)
        {
            Salario = salario;
            CargoConfiança = cargoConfiança;
        }

        public override decimal CustoMensal(decimal ferias, decimal decimoTerceiro, decimal fgts, decimal provisaoMulta, decimal previdenciario)
        {
            decimal percFerias = ferias * (11.11 / 100);
            decimal percDecimoTerceiro = decimoTerceiro * (8.33 / 100);
            decimal percFgts = fgts * (8 / 100);
            decimal fgtsMulta = (fgts / provisaoMulta) * (4 / 100);
            decimal percPrevidenciario = previdenciario * (7.93 / 100);
            return Salario + percFerias + percDecimoTerceiro + percFgts + percFgts + percFgts;
        }
    }
}
