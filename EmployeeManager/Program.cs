using EmployeeManager;
using System.ComponentModel;
using System.ComponentModel.Design;

// Employee List
List<Employee> employees = new List<Employee> { };
int n = 0;
Menu(employees, n);

// Methods
static void Menu(List<Employee> employees, int a)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("Menu");
    Console.WriteLine("---------------------");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. List Employees");
    Console.WriteLine("3. Remove Employee");
    Console.WriteLine("4. Quit/Exit");
    Console.WriteLine("---------------------");
    int choice = Convert.ToInt16(Console.ReadLine());
    Response(employees, choice, a);
}

static void Response(List<Employee> employees, int option, int a) 
{
    if (option == 1)
    {
        AddEmployee(employees, a);
    }
    else if (option == 2)
    {
        DisplayList(employees, a);
    }
    else if (option == 3)
    {
        RemoveEmployee(employees, a);
    }
    else if (option == 4)
    {
        Console.WriteLine("Thank you and goodbye");
    }
    else
    {
        Console.WriteLine("Please enter a valid option.");
        Menu(employees, a);
    }
}

// Menu option 1
static void AddEmployee(List<Employee> employees, int a) 
{
    Employee person = new Employee();

    person.listNum = a + 1;

    Console.WriteLine("Please enter your first name: ");
    person.FirstName = Console.ReadLine();

    Console.WriteLine("Please enter your last name: ");
    person.LastName = Console.ReadLine();

    Console.WriteLine("Please enter your Id: ");
    person.Id = Console.ReadLine();

    /*
        Console.WriteLine("Please enter how many hours worked: ");
        person.Hours = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Employee Name: " + person.FullName);
        Console.WriteLine("Employee Id: " + person.Id);
        Console.WriteLine("Hours Worked: " + person.Hours);
        Console.WriteLine("");
        Console.WriteLine("The weekly wage is £" + person.WeeklyWage.ToString("F"));
    */

    employees.Add(person);
    Console.WriteLine("Employee added successfully");
    Menu(employees, a + 1);
}

// Menu option 2
static void DisplayList(List<Employee> employees, int a) 
{
    foreach (Employee employee in employees)
    {
        Console.WriteLine(employee.ToString());
    }
    Menu(employees, a);
}

// Menu option 3
static void RemoveEmployee(List<Employee> employees, int a) 
{
    Console.WriteLine("Please enter the number you want to delete in list: ");
    int removeNum = Convert.ToInt16(Console.ReadLine());
    Menu(employees, a);
}




