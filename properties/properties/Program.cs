using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {

        public class Employee
        {
            private int _id;             //unused variable
            private string _name;
            private int _salary;

            public int ID
            {
                set;
                get;
            }

            public string Name
            {
                set
                {
                    this._name = value;
                }
                get
                {
                    return string.IsNullOrEmpty(this._name) ? "No name" : this._name;
                }
            }

            public int Salary
            {
                set
                {
                    this._salary = value;
                }
                get
                {
                    return this._salary;
                }
            }
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.ID = 10010;
            e1.Name = "Mark";
            e1.Salary = 5000;

            Console.WriteLine("ID: {0}", e1.ID);
            Console.WriteLine("Name: {0}", e1.Name);
            Console.WriteLine("Salary: {0}", e1.Salary);

            Console.ReadLine();

        }
    }
}
