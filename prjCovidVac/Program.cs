using System;

namespace prjCovidVac
{
    class Program
    {
        static void Main(string[] args)
        {
            //capture the info from the capture class
            capture c = new capture();
            c.getPatientDetails();

            //print everything that is inside the classes
            print_slip p = new print_slip();
            p.printReport();
        }
    }
}
