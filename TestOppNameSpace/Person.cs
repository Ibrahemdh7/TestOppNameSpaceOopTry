using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOppNameSpace
{

    class Employee
    {
        public int id;
        public string name;
        public string address;
        public string phoneNo;
        public double salary;
        public const double tax = 0.15;

        public double getNetSalary()
        {
            double netSal = salary - (salary * tax);
            return netSal;
        }

        public string getEmployeeData()
        {
            string alldata = "ID: " + id + "\n";
            alldata += "Name: " + name + "\n";
            alldata += "Address: " + address + "\n";
            alldata += "Phone:" + phoneNo + "\n";
            alldata += "Salary: " + salary + "\n";
            alldata += "Net Salary: " + getNetSalary() + "\n";
            return alldata;
        }

        public void printEmployeeData()
        {
            Console.WriteLine(getEmployeeData());
        }
    }
  
}
