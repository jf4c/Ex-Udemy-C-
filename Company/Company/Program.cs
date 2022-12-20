using Company.Entities;
using System.Globalization;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            List<Employee> employees = new List<Employee>();
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y / n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Employee employeeOutsourced = new OutsourceEmployee(name, hour, valuePerHour, addCharge);
                    employees.Add(employeeOutsourced);
                }
                else
                {
                    Employee employee = new Employee(name, hour, valuePerHour);
                    employees.Add(employee);
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee element in employees)
            {
                Console.WriteLine(element.Name + " - $" + element.Payment());
            }
            

        }
    }
}