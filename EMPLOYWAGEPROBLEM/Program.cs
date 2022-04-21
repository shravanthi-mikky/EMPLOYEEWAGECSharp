// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employ Wage Computation Program!");
int WagePerHour = 20;
int WorkingHours;
Random attendanceCheck = new();
int isPresent = attendanceCheck.Next(0, 2);
Console.WriteLine(isPresent);
if (isPresent == 1)
{
    Console.WriteLine("Employee is present!");
    WorkingHours = 8;
}
else
{
    Console.WriteLine("Employee is Absent!");
    WorkingHours = 0;
}
int EmployeeWage = WagePerHour * WorkingHours;
Console.WriteLine("The Employee wage is : " + EmployeeWage);
