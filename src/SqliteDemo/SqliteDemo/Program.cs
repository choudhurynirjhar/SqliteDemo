using System;

namespace SqliteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeContext = new EmployeeContext(@"Persist Security Info = False; Integrated Security = true; Initial Catalog = TimeManagement; server = Nirjhar-Tab\SQLEXPRESS");
            var employeeProvider = new EmployeeProvider(employeeContext);
            var employee = employeeProvider.Get(1002);
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Address: {employee.Address}");
        }
    }
}
