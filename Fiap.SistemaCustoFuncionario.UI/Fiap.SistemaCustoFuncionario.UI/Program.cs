
using Fiap.SistemaCustoFuncionario.UI.Models;

var funcClt1 = new FuncionarioClt(TipoFuncionario.Ativo, 1, "Jose Silva", "Masculino", 1500, true);
var funcClt2 = new FuncionarioClt(TipoFuncionario.Ativo, 2, "Joao Carvalho", "Masculino", 2000, false);
var funcClt3 = new FuncionarioClt(TipoFuncionario.Ativo, 3, "Maria Souza", "Feminino", 2100, true);
var funcClt4 = new FuncionarioClt(TipoFuncionario.Ativo, 4, "Marta Castilho", "Feminino", 7500, false);

var funcionariosClt = new List<FuncionarioClt>();

funcionariosClt.Add(funcClt1);
funcionariosClt.Add(funcClt2);
funcionariosClt.Add(funcClt3);
funcionariosClt.Add(funcClt4);

for(int i = 0; i < funcionariosClt.Count; i++)
{
    Console.WriteLine(funcionariosClt.ElementAt(i));
}

var funcPj1 = new FuncionarioPj(TipoFuncionario.Ativo, 21, "Mario Cavalcante", "Masculino", 300, 60, "123.123.123-11");
var funcPj2 = new FuncionarioPj(TipoFuncionario.Inativo, 22, "Andre Junior", "Masculino", 150, 70, "123.123.123-12");
var funcPj3 = new FuncionarioPj(TipoFuncionario.Ativo, 23, "Vitoria Andrade", "Feminino", 200, 75, "123.123.123-13");
var funcPj4 = new FuncionarioPj(TipoFuncionario.Ativo, 24, "Marcela Campos", "Feminino", 250, 80, "123.123.123-14");

var funcionariosPj = new List<FuncionarioPj>();

funcionariosPj.Add(funcPj1);
funcionariosPj.Add(funcPj2);
funcionariosPj.Add(funcPj3);
funcionariosPj.Add(funcPj4);

foreach (var pj in funcionariosPj)
{
    Console.WriteLine(pj);
}

Console.WriteLine(funcPj1.CustoMensal());
Console.WriteLine(funcPj2.CustoMensal());
Console.WriteLine(funcPj3.CustoMensal());
Console.WriteLine(funcPj4.CustoMensal());

Console.WriteLine("Informe o nr de registro do funcionário CLT para aumentar o salário: ");
int nrRegClt = Convert.ToInt32(Console.ReadLine());

foreach (var clt in funcionariosClt)
{
    if(clt.CodigoRegistro == nrRegClt)
    {
        Console.WriteLine("Informe o percentual para aumento: ");
        decimal percent = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(clt.AumentoSalario(percent));
        break;
    }
    else
    {
        Console.WriteLine("Numero de registro inexistente");
    }
}

Console.WriteLine("Informe o nr de registro do funcionario PJ para aumentar o salário: ");
int nrRegPj = Convert.ToInt32(Console.ReadLine());

foreach (var funcPj in funcionariosPj)
{
    if(funcPj.CodigoRegistro == nrRegPj)
    {
        Console.WriteLine("Informe o valor para aumento: ");
        decimal aumento = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(funcPj.AumentoSalario(aumento));
        break;
    }
    else
    {
        Console.WriteLine("Numero de registro inexistente");
    }
}

Console.WriteLine("Informe o nr de registro do funcionario para consulta de dados: ");
int nrReg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe 1 se for PJ e 2 se for CLT: ");
int cltOuPj = Convert.ToInt32(Console.ReadLine());

if(cltOuPj == 1)
{
    foreach (var func in funcionariosPj)
    {
        if (func.CodigoRegistro == nrReg)
        {
            Console.WriteLine(func);
            break;
        }
        else
        {
            Console.WriteLine("Numero de registro inexistente nos cadastros PJ");
        }
    }
}
else if(cltOuPj == 2)
{
    foreach (var func in funcionariosClt)
    {
        if (func.CodigoRegistro == nrReg)
        {
            Console.WriteLine(func);
            break;
        }
        else
        {
            Console.WriteLine("Numero de registro inexistente nos cadastros CLT");
        }
    }
}




Console.WriteLine("Informe o nr de registro do funcionario para exibição do custo mensal: ");
int nrRegCustoMensal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe 1 se for PJ e 2 se for CLT: ");
cltOuPj = Convert.ToInt32(Console.ReadLine());

if(cltOuPj == 1)
{
    foreach (var func in funcionariosPj)
    {
        if (func.CodigoRegistro == nrRegCustoMensal)
        {
            Console.WriteLine(func.CustoMensal());
            break;
        }
        else
        {
            Console.WriteLine("Numero de registro inexistente nos cadastros PJ");
        }
    }
}
else if(cltOuPj == 2)
{
    foreach (var func in funcionariosClt)
    {
        if (func.CodigoRegistro == nrRegCustoMensal)
        {
            Console.WriteLine("Informe o valor das ferias: ");
            double ferias = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do decimo terceiro: ");
            double decimoTerceiro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do fgts: ");
            double fgts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor da provisao de multa: ");
            double provisaoMulta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do previdenciario: ");
            double previdenciario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(func.CustoMensal(ferias, decimoTerceiro, fgts, provisaoMulta, previdenciario));
            break;
        }
        else
        {
            Console.WriteLine("Numero de registro inexistente nos cadastros CLT");
        }
    }
}
