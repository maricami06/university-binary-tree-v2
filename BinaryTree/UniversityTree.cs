using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class UniversityTree
    {
        public Nodo_position Root;

        public void CreatePosition (Nodo_position padre, Position positionToCreate, string padrePositionName)
        {
            Nodo_position newNodo = new Nodo_position();
            newNodo.Position = positionToCreate;

            if(Root == null)
            {
                Root = newNodo;
                return;
            }

            if(padre == null)
            {
                return;
            }

            if(padre.Position.name == padrePositionName)
            {
                if(padre.Left == null)
                {
                    padre.Left = newNodo;
                    return;
                }
                padre.Right = newNodo;
                return;
            }
            CreatePosition(padre.Left, positionToCreate, padrePositionName);
            CreatePosition(padre.Right, positionToCreate, padrePositionName);
        }

       /* public void PrintTree(Nodo_position from)
        {
            if(from == null)
            {
                return;
            }
            System.Console.WriteLine($"{from.Position.name} : ${from.Position.salary}");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }
       */
        public float AddSalaries(Nodo_position from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.salary + AddSalaries(from.Left) + AddSalaries(from.Right);
        }

        public float QuantityOfEmployees(Nodo_position from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.cant + QuantityOfEmployees(from.Left) + QuantityOfEmployees(from.Right);
        }

        public float ImpTotal(Nodo_position from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.ImpuXSalary() + ImpTotal(from.Left) + ImpTotal(from.Right);
        }

        public float higherSalary(Nodo_position from)
        {
            if (from == null)
            {
                return 0;
            }

            float maxIzq = from.Left.Position.salary;

            while (from.Left.Position.salary > maxIzq)
            {
                maxIzq = from.Left.Position.salary;
            }

            float maxDr = from.Right.Position.salary;


            while (from.Right.Position.salary > maxDr)
            {
                maxDr = from.Right.Position.salary;
            }

            float maxSuel = 0;
            if (maxIzq > maxDr)
            {
                maxSuel = maxIzq;
            }
            else if (maxDr > maxIzq)
            {
                maxSuel = maxDr;
            }

            return maxSuel;
        }
        
        public float salaryOfAnEmployee(Nodo_position from)
        {
            float totalSalary = 0;
            if (from == null)
            {
                return 0;
            }
            if (from.Position.name == "Vicepresidente Financiero")
            {
                totalSalary = from.Position.salary;
                System.Console.WriteLine($"Salary the " + $"{from.Position.name}");
            }
            
            return totalSalary + salaryOfAnEmployee(from.Left) + salaryOfAnEmployee(from.Right);
            
        }

    }
}
