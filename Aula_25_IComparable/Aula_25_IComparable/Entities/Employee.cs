﻿using System;
using System.Globalization;

namespace Aula_25_IComparable.Entities
{
    class Employee : IComparable                          //Declarado para poder comparar os itens da lista
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: Argument is not an employee!");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
