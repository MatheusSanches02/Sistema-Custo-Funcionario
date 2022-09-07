using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    internal abstract class Funcionario
    {
        public TipoFuncionario Tipo { get; set; }
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }

        protected Funcionario()
        {
        }

        protected Funcionario(TipoFuncionario tipo, int codigoRegistro, string nome, string genero)
        {
            Tipo = tipo;
            CodigoRegistro = codigoRegistro;
            Nome = nome;
            Genero = genero;
        }

        public virtual decimal CustoMensal()
        {
            return 0;
        }
        public abstract decimal AumentoSalario(decimal aumento);

        public override string ToString()
        {
            return $"Tipo: {Tipo}, Codigo Registro: {CodigoRegistro}, Nome: {Nome}, Genero: {Genero}";
        }

    }

    public enum TipoFuncionario
    {
        Ativo, Inativo
    }
}
