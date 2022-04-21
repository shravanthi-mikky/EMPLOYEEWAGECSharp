// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employ Wage Computation Program!");
Random attendanceCheck = new();
int isPresent = attendanceCheck.Next(0, 2);
Console.WriteLine(isPresent);
if (isPresent == 1)
    Console.WriteLine("Employee is present!");
else
    Console.WriteLine("Employee is Absent!");
