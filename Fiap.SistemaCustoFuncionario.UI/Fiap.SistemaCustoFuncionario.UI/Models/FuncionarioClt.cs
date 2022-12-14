using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public decimal CustoMensal(double ferias, double decimoTerceiro, double fgts, double provisaoMulta, double previdenciario)
        {
            decimal percFerias = (decimal)(ferias * (11.11 / 100));
            decimal percDecimoTerceiro = (decimal)(decimoTerceiro * (8.33 / 100));
            decimal percFgts = (decimal)(fgts * (8 / 100));
            decimal fgtsMulta = (decimal)((fgts / provisaoMulta) * (4 / 100));
            decimal percPrevidenciario = (decimal)(previdenciario * (7.93 / 100));
            return Salario + percFerias + percDecimoTerceiro + percFgts + fgtsMulta + percPrevidenciario;
        }

        public override decimal AumentoSalario(decimal percent)
        {
            decimal total = Salario * (percent / 100);
            return Salario + total;
        }

        public override string ToString()
        {
            return base.ToString() + $" Sálário: {Salario}";
        }

    }
}
