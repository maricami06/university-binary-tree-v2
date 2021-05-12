using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.name = "Rector";
            rectorPosition.salary = 1000;
            rectorPosition.average = 26;
            rectorPosition.cant = 1;

            Position vicFinancieroPosition = new Position();
            vicFinancieroPosition.name = "Vicepresidente Financiero";
            vicFinancieroPosition.salary = 750;
            vicFinancieroPosition.average = 24;
            vicFinancieroPosition.cant = 1;
            Position contadorFinPosition = new Position();
            contadorFinPosition.name = "Contador Financiero";
            contadorFinPosition.salary = 500;
            contadorFinPosition.average = 22;
            contadorFinPosition.cant = 1;
            Position jefeFinPosition = new Position();
            jefeFinPosition.name = "Jefe Financiero";
            jefeFinPosition.salary = 610;
            jefeFinPosition.average = 16;
            jefeFinPosition.cant = 1;
            Position secre1FinPosition = new Position();
            secre1FinPosition.name = "Secretaria1 Financiero";
            secre1FinPosition.salary = 350;
            secre1FinPosition.average = 20;
            secre1FinPosition.cant = 1;
            Position secre2FinPosition = new Position();
            secre2FinPosition.name = "Secretaria2 Financiero";
            secre2FinPosition.salary = 310;
            secre2FinPosition.average = 18;
            secre2FinPosition.cant = 1;

            Position vicAcademicoPosition = new Position();
            vicAcademicoPosition.name = "Vicepresidente Academico";
            vicAcademicoPosition.salary = 780;
            vicAcademicoPosition.average = 14;
            vicAcademicoPosition.cant = 1;
            Position jefeAcademicoPosition = new Position();
            jefeAcademicoPosition.name = "Jefe Academico";
            jefeAcademicoPosition.salary = 640;
            jefeAcademicoPosition.average = 12;
            jefeAcademicoPosition.cant = 1;
            Position secre2AcademicoPosition = new Position();
            secre2AcademicoPosition.name = "Secretria2 Academico";
            secre2AcademicoPosition.salary = 360;
            secre2AcademicoPosition.average = 8;
            secre2AcademicoPosition.cant = 1;
            Position secre1AcademicoPosition = new Position();
            secre1AcademicoPosition.name = "Secretria1 Academico";
            secre1AcademicoPosition.salary = 400;
            secre1AcademicoPosition.average = 10;
            secre1AcademicoPosition.cant = 1;
            Position asist2AcademicoPosition = new Position();
            asist2AcademicoPosition.name = "Asistente2 Academico";
            asist2AcademicoPosition.salary = 170;
            asist2AcademicoPosition.average = 6;
            asist2AcademicoPosition.cant = 1;
            Position asist1AcademicoPosition = new Position();
            asist1AcademicoPosition.name = "Asistente1 Academico";
            asist1AcademicoPosition.salary = 250;
            asist1AcademicoPosition.average = 2;
            asist1AcademicoPosition.cant = 1;
            Position mensajeroAcademicoPosition = new Position();
            mensajeroAcademicoPosition.name = "Mensajero Academico";
            mensajeroAcademicoPosition.salary = 90;
            mensajeroAcademicoPosition.average = 4;
            mensajeroAcademicoPosition.cant = 1;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);

            universityTree.CreatePosition(universityTree.Root, vicFinancieroPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, contadorFinPosition, vicFinancieroPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre1FinPosition, contadorFinPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre2FinPosition, contadorFinPosition.name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinancieroPosition.name);

            universityTree.CreatePosition(universityTree.Root, vicAcademicoPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, jefeAcademicoPosition, vicAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre2AcademicoPosition, jefeAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, secre1AcademicoPosition, jefeAcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, asist2AcademicoPosition, secre1AcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, mensajeroAcademicoPosition, asist2AcademicoPosition.name);
            universityTree.CreatePosition(universityTree.Root, asist1AcademicoPosition, secre1AcademicoPosition.name);

            /*universityTree.PrintTree(universityTree.Root);*/

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: ${totalSalary}");

           /* float totalcantEm = universityTree.QuantityOfEmployees(universityTree.Root);
            Console.WriteLine($"Total: ${totalcantEm}");*/

            float totalAve = universityTree.AddSalaries(universityTree.Root)/ universityTree.QuantityOfEmployees(universityTree.Root);
            Console.WriteLine($"The salary average: ${totalAve}");


            float totalimp = universityTree.ImpTotal(universityTree.Root);
            Console.WriteLine($"Money for total tax: ${totalimp}");

            float may = universityTree.higherSalary(universityTree.Root);
            Console.WriteLine($"Higher salary not including father: ${may}");

            float salaryEmpl = universityTree.salaryOfAnEmployee(universityTree.Root);
            Console.WriteLine($"Salary for a given positione: ${salaryEmpl}");

            Console.ReadLine();
        }
    }
}
