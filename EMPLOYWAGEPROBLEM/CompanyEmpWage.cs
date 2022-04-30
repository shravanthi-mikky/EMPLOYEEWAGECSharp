using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYWAGEPROBLEM
{
    public interface Isalary
    {
        public void salary();
        public void addCompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
    }
    public class CompanyEmpWage
    {
        public int wagePerHour;
        public int workingHours;
        public int workingDaysPerMonth;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public string Company;
        public int totalSalary;
        public CompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.Company = Company;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalSalary(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Total Employee Wage for Company : " + this.Company + " is: " + this.totalSalary;
        }

    }
}
