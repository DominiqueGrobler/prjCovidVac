using System;

namespace prjCovidVac
{
    class Program
    {
        static void Main(string[] args)
        {
            //connect to the object 
            Info i = new Info();

            //request the basic info
            Console.Write("Enter the Hospital Name:");
            i.setHospital_Name(Console.ReadLine());

            Console.Write("Is it a Private or Public Hospital:");
            i.setHospitalType(Convert.ToBoolean(Console.ReadLine()));

            Console.Write("Enter the Address:");
            i.setAddress(Console.ReadLine());

            Console.Write("In what Province is the Hospital:");
            i.setProvince(Convert.ToChar(Console.ReadLine()));

            Console.Write("In what Province is the Hospital:");
            i.setArray(Convert.ToChar(Console.ReadLine()));

            //capture the info from the capture class
            capture c = new capture();
            c.getPatientDetails();

            //print everything that is inside the classes
            print_slip p = new print_slip();
            p.printReport();
        }
    }
}
