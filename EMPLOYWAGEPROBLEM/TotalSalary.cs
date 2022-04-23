using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYWAGEPROBLEM
{
    public class TotalSalary
    {
        int wagePerHour = 20;
        int workingHours = 0;
        int workingDaysPerMonth = 0;
        int maxWorkingDays = 20;
        int maxWorkingHours = 100;
        public void salary()
        {
            
            Random attendanceCheck = new();
            int isPresent = attendanceCheck.Next(0, 4);
            Console.WriteLine(isPresent);
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is present and working Full Time!");
                // WorkingHours = 8;
            }
            else if (isPresent == 2)
            {
                Console.WriteLine("Employee is working for part Time!");
                //WorkingHours = 4;
                //if isPresent is 2 then we consider it as part time and working hours are 4
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
                //WorkingHours = 0;
            }

            while ((workingHours < maxWorkingHours) && (workingDaysPerMonth < maxWorkingDays))
            {

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
                workingDaysPerMonth++;
            }
            Console.WriteLine("Total Working Hours : " + workingHours);
            Console.WriteLine("Total working Days Per Month : " + workingDaysPerMonth);
            int totalSalary = wagePerHour * workingHours;
            Console.WriteLine("Total Salary of Employee per Month : " + totalSalary);
        }
        

    }
}
