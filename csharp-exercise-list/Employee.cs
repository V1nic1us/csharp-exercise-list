using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_list
{
    internal class Employee
    {
        public int Id { get; private set; }
        private string name;
        private double salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            this.salary += salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"name:{this.name}  salary:{this.salary}  id:{this.Id}";
        }
    }
}
