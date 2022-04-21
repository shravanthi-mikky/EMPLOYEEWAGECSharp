// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employ Wage Computation Program!");
int WagePerHour = 20;
int WorkingHours;
Random attendanceCheck = new();
int isPresent = attendanceCheck.Next(0, 3);
Console.WriteLine(isPresent);
if (isPresent == 1)
{
    Console.WriteLine("Employee is present and working Full Time!");
    WorkingHours = 8;
}
else if (isPresent == 2)
{
    Console.WriteLine("Employee is working for part Time!");
    WorkingHours = 4;
}
else
{
    Console.WriteLine("Employee is Absent!");
    WorkingHours = 0;
    //if isPresent is 2 then we consider it as part time and working hours are 4
}
int EmployeeWage = WagePerHour * WorkingHours;
Console.WriteLine("The Employee Daily Wage is : " + EmployeeWage);
