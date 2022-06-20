
using EntityFrameworkData;
using EntityFrameworkData.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();

            Console.WriteLine("Adding a new Employee");
            obj.Insert(new Employee { Name = "anush", Address = "Delhi" });
            obj.Insert(new Employee { Name = "rahul", Address = "gupta" });
            PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 2");
            //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            //var employee = obj.GetEmplpoyeeById(2);
            //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 2");
            //obj.Delete(2);
            //PrintAllEmployees();

            Console.ReadLine();
        }

        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CRUDManager obj = new CRUDManager();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }
    }
}