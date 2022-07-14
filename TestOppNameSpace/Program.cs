using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO ;




namespace TestOppNameSpace
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Your Number Phone");
            string phone = Console.ReadLine();
            Console.WriteLine("==============================================");

            Employee e1 = new Employee();
            e1.id =  id;
            e1.name = name;
            e1.address = city;
            e1.phoneNo = phone;
            e1.salary = 15000;
            e1.printEmployeeData();
            Console.WriteLine("==============================================");
            Employee e2 = new Employee();
            e2.id = 12345678;
            e2.name = "Dempsy";
            e2.address = "Origins";
            e2.phoneNo = "0551626451";
            e2.salary = 20000;
            e2.printEmployeeData();
            Console.WriteLine("==============================================");

            Console.WriteLine("Enter Your Id");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string city2 = Console.ReadLine();
            Console.WriteLine("Enter Your Number Phone");
            string phone2 = Console.ReadLine();
            Console.WriteLine("==============================================");
            Employee e3 = new Employee();
            e3.id = id2;
            e3.name = name2;
            e3.address = city2;
            e3.phoneNo = phone2;
            e3.salary = 20000;
            e3.printEmployeeData();

        }
    }
}
