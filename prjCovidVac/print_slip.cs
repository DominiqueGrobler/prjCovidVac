using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class print_slip
    {
        public void printReport()
        {
            //creating the link  to the object
            Info i = new Info();
            Console.Clear();

            //Welcome message
            Console.WriteLine("COVID-19-VACCINE");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("General Information");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Hospital Name: " + i.getHospital_Name());
            Console.WriteLine("Address: " + i.getAddress());
            Console.WriteLine("Public or Private: " + i.getHospitalType());
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Information on each of the patients: ");

            for (int x= 0; x <i.size(); x++)
            {
                Console.WriteLine("ID Number: {0}" + "\n Patient Name: {1}" + "\nPatient Surname: {2}" + "\n Refering Doctor: {3} "
                    + " \n Bloodtype: {4}" + "\n Any Allergies: {5}" + "\n Did you have Covid: {6}" + " \n What vaccine are you getting: {7}",
                    i.getIDNumber(x), i.getName(x), i.getSurame(x), i.getRefDr(x), i.getBloodType(x), i.getAllergies(x),
                    i.getBCovid(x), i.getVaccine(x));
                Console.WriteLine("----------------------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
