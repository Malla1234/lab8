using System;
using System.Collections.Generic;
using System.Linq;
namespace lab8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee S1 = new Employee() { Id = 110, Name = "Johan", Gender = "M", Salary = 1200 };
            Employee S2 = new Employee() { Id = 111, Name = "Kalle", Gender = "M", Salary = 1300 };
            Employee S3 = new Employee() { Id = 112, Name = "Simon", Gender = "M", Salary = 1400 };
            Employee S4 = new Employee() { Id = 113, Name = "Elias", Gender = "M", Salary = 1500 };
            Employee S5 = new Employee() { Id = 114, Name = "Lasse", Gender = "M", Salary = 1600 };

            Stack<Employee> EmploStack = new Stack<Employee>();
            EmploStack.Push(S1);
            EmploStack.Push(S2);
            EmploStack.Push(S3);
            EmploStack.Push(S4);
            EmploStack.Push(S5);
           Console.WriteLine("Items kvar i stacken:" + EmploStack.Count);

            foreach (Employee stackEmplo in EmploStack)
            {
                Console.WriteLine($"ID={stackEmplo.Id} Names={stackEmplo.Name} Gender={stackEmplo.Gender} Salary= {stackEmplo.Salary}");
                
            }
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            Employee EP1 = EmploStack.Pop();
            Console.WriteLine($"Id={EP1.Id} Names={EP1.Name} Gender={EP1.Gender} Salary= {EP1.Salary}");
            Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

            Employee EP2 = EmploStack.Pop();
            Console.WriteLine($"Id={EP2.Id} Names={EP2.Name} Gender={EP2.Gender} Salary= {EP2.Salary}");
            Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

            Employee EP3 = EmploStack.Pop();
            Console.WriteLine($"Id={EP3.Id} Names={EP3.Name} Gender={EP3.Gender} Salary= {EP3.Salary}");
            Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

            Employee EP4 = EmploStack.Pop();
            Console.WriteLine($"Id={EP4.Id} Names={EP4.Name} Gender={EP4.Gender} Salary= {EP4.Salary}");
            Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

            Employee EP5 = EmploStack.Pop();
            Console.WriteLine($"Id={EP5.Id} Names={EP5.Name} Gender={EP5.Gender} Salary= {EP5.Salary}");
            Console.WriteLine("items kvar i stacken:" + EmploStack.Count);

            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            EmploStack.Push(S1);
            EmploStack.Push(S2);
            EmploStack.Push(S3);
            EmploStack.Push(S4);
            EmploStack.Push(S5);

            Employee PE = EmploStack.Peek();
            Console.WriteLine($"Id={PE.Id} Names={PE.Name} Gender={PE.Gender} Salary= {PE.Salary}");
            Console.WriteLine("Items i kön:" + EmploStack.Count);
            Console.WriteLine($"Id={PE.Id} Names={PE.Name} Gender={PE.Gender} Salary= {PE.Salary}");
            Console.WriteLine("Items i kön:" + EmploStack.Count);

            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            if (EmploStack.Contains(S2) == true)
            {
                Console.WriteLine(S2.Name + " " + "finns i listan");
            }
            else
            {
                Console.WriteLine(S2.Name + " " + "finns inte i listan");
            }
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            List<Employee> listEmplo = new List<Employee>();
            listEmplo.Add(S1);
            listEmplo.Add(S2);
            listEmplo.Add(S3);
            listEmplo.Add(S4);
            listEmplo.Add(S5);

            if (listEmplo.Contains(S2) == true)
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

             Employee findemp = listEmplo.Find(le => le.Gender == "M");
             Console.WriteLine($"Id={findemp.Id} Names={findemp.Name} Gender={findemp.Gender} Salary= {findemp.Salary}");

            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            List<Employee> allMale = new List<Employee>(listEmplo.FindAll(lm => lm.Gender == "M"));
            foreach (Employee mgender in allMale)
            {

                Console.WriteLine($"Id={mgender.Id} Names={mgender.Name} Gender={mgender.Gender} Salary= {mgender.Salary}");

            }
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
        }

    }
}