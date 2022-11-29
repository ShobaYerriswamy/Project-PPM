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
        Console.WriteLine("Enter 'S' to QUIT the application");

        var userInput = Console.ReadLine();
            
        ProjectManager PM =  new ProjectManager();
        EmployeeManager EM = new EmployeeManager();
        RoleManager RM = new RoleManager();

        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter the Project Name");
                    var add = Console.ReadLine();
                    var newProject = new Project(add);
                    PM.AddProject(newProject);
                    Console.WriteLine("Project Added Successfully");
                    break;
                
                case "2":
                    PM.ViewProject();
                    break;

                case "3":
                    Console.WriteLine("Enter the Employee Name");
                    var add1 = Console.ReadLine();
                    var newEmployee = new Employee(add1);
                    EM.AddEmployee(newEmployee);
                    Console.WriteLine("Employee Added Successfully");
                    break;
                
                case "4":
                    EM.ViewEmployee();
                    break;

                case "5":
                    Console.WriteLine("Enter the Role Name");
                    var add2 = Console.ReadLine();
                    var newRole = new Role(add2);
                    RM.AddRole(newRole);
                    Console.WriteLine("Role Added Successfully");
                    break;
                  
                case "6":
                    RM.ViewRole();
                    break;
                    
                case "S":
                    return;

                default:
                    Console.WriteLine("Select Valid Operation");
                    break;
            }   

            Console.WriteLine("Select Operation");
            userInput = Console.ReadLine();
        }
    }
}

public class Project
{
    public string ProjectName { get; set; }

    public Project(string projectname)
    {
        ProjectName = projectname;
    } 
}

public class ProjectManager
{
    List<Project> Projects = new List<Project>();
    
    public void AddProject(Project project)
    {
        Projects.Add(project);
    }
    
     public void displayAllProjects(Project project)
    {
        Console.WriteLine("[" + project.ProjectName + "]");
    }
    
    public void ViewProject()
    {
        foreach (var i in Projects)
        {
            displayAllProjects(i);
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

public class EmployeeManager
{
    List<Employee> Employees = new List<Employee>();
    
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
     public void displayAllEmployees(Employee employee)
    {
        Console.WriteLine("[" + employee.EmployeeName + "]");
    }
    
    public void ViewEmployee()
    {
        foreach (var i in Employees)
        {
            displayAllEmployees(i);
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

public class RoleManager
{
    List<Role> Roles = new List<Role>();
    
    public void AddRole(Role role)
    {
        Roles.Add(role);
    }
    
     public void displayAllRoles(Role role)
    {
        Console.WriteLine("[" + role.RoleName + "]");
    }
    
    public void ViewRole()
    {
        foreach (var i in Roles)
        {
            displayAllRoles(i);
        }
    }
}

