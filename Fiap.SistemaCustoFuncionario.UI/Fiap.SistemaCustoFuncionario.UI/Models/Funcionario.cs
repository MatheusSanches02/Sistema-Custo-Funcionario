﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.SistemaCustoFuncionario.UI.Models
{
    internal class Funcionario
    {
        public TipoFuncionario Tipo { get; set; }
        public int CodigoRegistro { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
    }

    public enum TipoFuncionario
    {
        Clt, Pj
    }
}