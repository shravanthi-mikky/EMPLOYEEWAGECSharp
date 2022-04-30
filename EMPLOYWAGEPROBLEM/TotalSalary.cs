using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYWAGEPROBLEM
{
    public class TotalSalary : Isalary
    {
        public int numOfCompany = 0;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        public TotalSalary()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, wagePerHour, maxWorkingDays, maxWorkingHours);
            this.companyEmpWageList.AddLast(companyEmpWage);
        }

        public void salary()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalSalary(this.salary(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int salary(CompanyEmpWage companyEmpWage)
        {
            int workingHours = 0;
            int workingDaysPerMonth = 0;
            int totalWorkingHours = 0;

            while ((totalWorkingHours <= companyEmpWage.maxWorkingHours) && (workingDaysPerMonth < companyEmpWage.maxWorkingDays))
            {
                Random attendanceCheck = new();
                int isPresent = attendanceCheck.Next(0, 4);
                workingDaysPerMonth++;
                switch (isPresent)
                {
                    case 1:
                        //Console.WriteLine("Employee is present and working Full Time!");
                        workingHours += 8;
                        break;
                    case 2:
                        //Console.WriteLine("Employee is present and working Part Time!");
                        workingHours += 4;
                        break;
                    case 0:
                        //Console.WriteLine("Employee is Absent!");
                        workingHours = 0;
                        break;
                    default:
                        //Console.WriteLine("Something went wrong!!");
                        break;
                }
                totalWorkingHours += workingHours;
                Console.WriteLine("Days# : " + workingDaysPerMonth + " Total Working Hours :" + workingHours);
            }
            int amount = (totalWorkingHours * companyEmpWage.wagePerHour);
            Console.WriteLine(amount);
            return amount;
        }
       

    }
}
