// See https://aka.ms/new-console-template for more information

using EMPLOYWAGEPROBLEM;

Console.WriteLine("Welcome to Employ Wage Computation Program!");
TotalSalary abc = new TotalSalary("abc",20,2,10);
TotalSalary xyz = new TotalSalary("xyz", 10, 4, 20);
abc.salary();
Console.WriteLine(abc.ToString());
xyz.salary();
Console.WriteLine(xyz.ToString());