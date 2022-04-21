// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employ Wage Computation Program!");
int WagePerHour = 20;
int WorkingHours=0;
int workingDaysPerMonth = 20;
Random attendanceCheck = new();
int isPresent = attendanceCheck.Next(0, 3);
Console.WriteLine(isPresent);

switch (isPresent)
{
    case 1:
        Console.WriteLine("Employee is present and working Full Time!");
        WorkingHours = 8;
        break;
    case 2:
        Console.WriteLine("Employee is present and working Part Time!");
        WorkingHours = 4;
        break;
    case 0:
        Console.WriteLine("Employee is Absent!");
        WorkingHours = 0;
        break;
        //default:
        //    Console.WriteLine("Something went wrong!!");
}

int employeeWage = WagePerHour * WorkingHours;
Console.WriteLine("The Employee Daily Wage is : " + employeeWage);
int totalSalary = employeeWage * workingDaysPerMonth;
Console.WriteLine("Total Salary of Employee per Month : " + totalSalary);