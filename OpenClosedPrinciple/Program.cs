using LiskovSubstitutionPrinciple.Implementation;
using OpenClosedPrinciple.Abstract;
using OpenClosedPrinciple.Interface;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "Nguyen Van Hieu"));
            employees.Add(new TemporaryEmployee(2, "Nguyen Van A"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.caculateBonus(100000).ToString(),
                employee.GetMinimumsalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "Hoang Anh Minh"));

            employeesOnly.Add(new TemporaryEmployee(2, "Le Quang Thang"));
            employeesOnly.Add(new ContractEmployee(3, "Nam Hoai Duc"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumsalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}