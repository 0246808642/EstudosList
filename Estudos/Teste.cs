using Estudos;
using System.Collections.Concurrent;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many employees will be registered? ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Employee #" + i + ":");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Salary: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            list.Add(new Employee(id, nome, salario));
        }
        Console.Write("Enter the employee id that will have salary increase : ");
         double emp = double.Parse(Console.ReadLine());

        Employee cty = list.Find(x => x.Id == emp);
        if (cty != null)
        {
            Console.Write("Enter the percentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cty.increaseSalary(porcentagem);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }
        Console.WriteLine();
        Console.WriteLine("Update list of employees: ");
        foreach (Employee obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}