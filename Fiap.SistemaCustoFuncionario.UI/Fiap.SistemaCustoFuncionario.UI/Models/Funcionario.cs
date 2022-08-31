using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    internal abstract class Funcionario : IFuncionario
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

        public abstract decimal CustoMensal();
    }

    public enum TipoFuncionario
    {
        Clt, Pj
    }
}
