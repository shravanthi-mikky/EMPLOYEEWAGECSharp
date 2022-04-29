// See https://aka.ms/new-console-template for more information

using EMPLOYWAGEPROBLEM;

Console.WriteLine("Welcome to Employ Wage Computation Program!");
TotalSalary totalSalary = new();
totalSalary.addCompanyEmpWage("abc", 20, 2, 10);
totalSalary.addCompanyEmpWage("xyz",10,4,20);
totalSalary.salary();
