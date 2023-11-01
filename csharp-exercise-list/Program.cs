using System;
using csharp_exercise_list;
using System.Collections.Generic;

namespace csharpExerciseList {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Funcionário");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o ID do Funcionário");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do Funcionário");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o salario do Funcionário");
                double salary = double.Parse(Console.ReadLine());
                Employee employee = new Employee(id, name, salary);
                employeeList.Add(employee);
                Console.WriteLine();
            }

            Console.WriteLine("digite o id do funcionario para aumento");
            int idEmployee = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcetagem para o aumento");
            double increase = double.Parse(Console.ReadLine());
            foreach (var item in employeeList)
            {
                if (item.Id == idEmployee)
                {
                    item.increaseSalary(increase);
                }
            }

            foreach (var item in employeeList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}