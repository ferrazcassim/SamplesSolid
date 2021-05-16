using SampleSRP.Entities;
using System;

namespace SampleSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee eDev = new Developer();
            Employee eDBA = new DBA();
            Employee eAgi = new Agile();
            Employee eMan = new Manager();


            Console.WriteLine($"Salario base do desenvolvedor: {eDev.GetBaseSalary()} | Salario incrementado do desenvolvedor: {eDev.CalculatedSalary}\n\n");
            Console.WriteLine($"Salario base do DBA: {eDBA.GetBaseSalary()} | Salario incrementado do DBA: {eDBA.CalculatedSalary}\n\n");
            Console.WriteLine($"Salario base do AGILE: {eAgi.GetBaseSalary()} | Salario incrementado do AGILE: {eAgi.CalculatedSalary}\n\n");
            Console.WriteLine($"Salario base do Manager: {eMan.GetBaseSalary()} | Salario incrementado do Manager: {eMan.CalculatedSalary}\n\n");
        }
    }
}
