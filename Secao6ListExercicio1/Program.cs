using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio1 {
    /*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. 
    
    Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.*/

    class Program {

        static void Main(string[] args) {

            List <Employee> employee = new List <Employee> ();
            int id;
            Console.Write("How many employees will be registered? ");
            int amount = int.Parse(Console.ReadLine());
            for(int i = 1; i <= amount; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: $");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            id = int.Parse(Console.ReadLine());
            Employee idTest = employee.Find(x => x.Id == id);
            if (idTest == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idTest.IncreaseSalary(percentage);
            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee func in employee) {
                Console.WriteLine(func);
            }


        }
    }
}