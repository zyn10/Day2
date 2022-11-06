using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp3
{

    delegate bool Promotable(Employee emp);


    class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empSalary { get; set; }
        public int empExperience { get; set; }

        public void promotion(List<Employee> employeeList, Promotable Eligible)
        {
            foreach(var employee in employeeList)
            {
                if(Eligible(employee))
                {
                    Console.WriteLine(employee.empName + " Promoted");
                }
            }
        }


    }

    class Program
    {

        public static bool Promote(Employee emp)
        {
            if(emp.empExperience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main()
        {
            List<Employee> employeeList = new List<Employee>();

            Employee ob = new Employee();

            employeeList.Add(new Employee { empId = 1, empName = "Awais", empSalary = 30000, empExperience = 5 });
            employeeList.Add(new Employee { empId = 2, empName = "Ali", empSalary = 40000, empExperience = 7 });
            employeeList.Add(new Employee { empId = 3, empName = "Ahmad", empSalary = 20000, empExperience = 3 });
            employeeList.Add(new Employee { empId = 4, empName = "Sara", empSalary = 50000, empExperience = 6 });
            employeeList.Add(new Employee { empId = 5, empName = "Waqas", empSalary = 10000, empExperience = 2 });

            Promotable prom = new Promotable(Promote);

            ob.promotion(employeeList, prom);
        }



    }



}
