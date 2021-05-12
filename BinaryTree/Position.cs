using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Position
    {
        public string name;
        public float salary;
        public float average;
        public int cant;

        public float ImpuXSalary()
        {
            float Impu = (salary * average) / 100;
            return Impu;
        }

    }
}
