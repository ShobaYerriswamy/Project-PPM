using System;

public class PrilificsProjectManager
{

    public static void Main(string[]args)
    {
        Console.WriteLine("Hello from the console PPM");
        Console.WriteLine("Enter 1 to Add Project");
        Console.WriteLine("Enter 2 to View Projects");
        Console.WriteLine("Enter 3 to Add Employee");
        Console.WriteLine("Enter 4 to View Employees");
        Console.WriteLine("Enter 5 to Add Role");
        Console.WriteLine("Enter 6 to View Roles");
        Console.WriteLine("Enter 'S' to exit the application");

        var userInput = Console.ReadLine();
            
        ProjectManagement obj =  new ProjectManagement();
        EmployeeManagement obj1 = new EmployeeManagement();
        RoleManagement obj2 = new RoleManagement();

        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter the Project Name");
                    var add = Console.ReadLine();
                    var newProject = new Project(add);
                    obj.AddProject(newProject);
                    Console.WriteLine("Added Successfully!");
                    break;
                
                case "2":
                    obj.ViewProject();
                    break;

                case "3":
                    Console.WriteLine("Enter the Employee Name");
                    var add1 = Console.ReadLine();
                    var newEmployee = new Employee(add1);
                    obj1.AddEmployee(newEmployee);
                    Console.WriteLine("Added Successfully!");
                    break;
                
                case "4":
                    obj1.ViewEmployee();
                    break;

                case "5":
                    Console.WriteLine("Enter the Role Name");
                    var add2 = Console.ReadLine();
                    var newRole = new Role(add2);
                    obj2.AddRole(newRole);
                    Console.WriteLine("Added Successfully!");
                    break;
                  
                case "6":
                    obj2.ViewRole();
                    break;
                    
                case "S":
                    return;

                default:
                    Console.WriteLine("Select valid Operation");
                    break;
            }   

            Console.WriteLine("Select Operation");
            userInput = Console.ReadLine();
        }
    }
}
public class Project
{
    public string ProjectName ; 

    public Project(string projectname)
    {
        ProjectName = projectname;
    }

    
}
public class ProjectManagement
{
    List<Project> Projects = new List<Project>();
    public void AddProject(Project project)
    {
        Projects.Add(project);
    }
     public void displayProject(Project project)
    {
        Console.WriteLine("[" + project.ProjectName + "]");
    }
    public void ViewProject()
    {
        foreach (var i in Projects)
        {
            displayProject(i);
        }
    }
}
public class Employee
{
    public string EmployeeName { get; set; }

    public Employee(string employeename)
    {
        EmployeeName = employeename;
    }
}
public class EmployeeManagement
{
    List<Employee> Employees = new List<Employee>();
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
     public void displayEmployee(Employee employee)
    {
        Console.WriteLine("[" + employee.EmployeeName + "]");
    }
    public void ViewEmployee()
    {
        foreach (var i in Employees)
        {
            displayEmployee(i);
        }
    }
}
public class Role
{
    public string RoleName { get; set; }

    public Role(string rolename)
    {
        RoleName = rolename;
    }
}
public class RoleManagement
{
    List<Role> Roles = new List<Role>();
    public void AddRole(Role role)
    {
        Roles.Add(role);
    }
     public void displayRole(Role role)
    {
        Console.WriteLine("[" + role.RoleName + "]");
    }
    public void ViewRole()
    {
        foreach (var i in Roles)
        {
            displayRole(i);
        }
    }
}

