using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSearchSample
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class DelegatesSearch
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Address = "123 Maple St" },
                new Employee { Id = 2, Name = "Bob", Address = "456 Oak St" },
                new Employee { Id = 3, Name = "Charlie", Address = "789 Pine St" },
                new Employee { Id = 4, Name = "David", Address = "321 Cedar St" },
                new Employee { Id = 5, Name = "Eve", Address = "654 Spruce St" }
            };

            Console.WriteLine("Enter the keyword to find an employee:");
            string keyword = Console.ReadLine();

            // Using Find method with delegate
            var foundEmployee = employees.Find(delegate (Employee emp)
            {
                return emp.Id.ToString().Contains(keyword) || emp.Name.Contains(keyword) || emp.Address.Contains(keyword);
            });

            if (foundEmployee != null)
            {
                Console.WriteLine("Found employee: Id = " + foundEmployee.Id + ", Name = " + foundEmployee.Name + ", Address = " + foundEmployee.Address);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            // Using FindAll method with lambda expression
            var selectedEmployees = employees.FindAll(emp => emp.Id.ToString().Contains(keyword) || emp.Name.Contains(keyword) || emp.Address.Contains(keyword));
            if (selectedEmployees.Count > 0)
            {
                Console.WriteLine("Other employees with matching criteria:");
                foreach (var emp in selectedEmployees)
                {
                    Console.WriteLine("Id = " + emp.Id + ", Name = " + emp.Name + ", Address = " + emp.Address);
                }
            }
            else
            {
                Console.WriteLine("No other employees with matching criteria found.");
            }
        }
    }
}
