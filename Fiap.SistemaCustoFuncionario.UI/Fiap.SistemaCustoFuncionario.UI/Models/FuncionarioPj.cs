using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    internal class FuncionarioPj : Funcionario, IFuncionarioPj
    {
        public decimal ValorHora { get; set; }
        public int QtdeHoras { get; set; }
        public string NrCnpj { get; set; }

        public FuncionarioPj()
        {
        }
        public FuncionarioPj(decimal valorHora, int qtdeHoras)
        {
            ValorHora = valorHora;
            QtdeHoras = qtdeHoras;
        }

        public FuncionarioPj(decimal valorHora, int qtdeHoras, string nrCnpj)
        {
            ValorHora = valorHora;
            QtdeHoras = qtdeHoras;
            NrCnpj = nrCnpj;
        }

        public FuncionarioPj(TipoFuncionario tipo, int codigoRegistro, string nome, string genero, decimal valorHora, int qtdeHoras, string nrCnpj) : base(tipo, codigoRegistro, nome, genero)
        {
            ValorHora = valorHora;
            QtdeHoras = qtdeHoras;
            NrCnpj = nrCnpj;
        }

        public override decimal CustoMensal()
        {
            return ValorHora * QtdeHoras;
        }

        public decimal CustoMensalHorasExtras(int horas)
        {
            int horasExtras = horas + QtdeHoras;
            return ValorHora * horasExtras;
        }

        public override decimal AumentoSalario(decimal aumento)
        {
            return ValorHora + aumento;
        }

        public override string ToString()
        {
            return base.ToString() + $"Valor da Hora: {ValorHora}, Quantidade de horas: {QtdeHoras}, CNPJ: {NrCnpj}";
        }
    }
}
