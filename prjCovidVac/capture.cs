using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class capture
    {
        public void getPatientDetails()
        {
            Info i = new Info();

            Console.Clear();
            // this is used to loop to the size of the patients you set in array
            for (int x = 0; x < i.size(); x++)// the size is there to see how many patients was entered in the array
            {
                Console.Write("Please enter the patient ID number: ");
                String ID_Number = Console.ReadLine();

                Console.Write("Please enter the patient " + (x + 1) + "name: ");
                String Name = Console.ReadLine();

                Console.Write("Please enter the patient surname: ");
                String Surname = Console.ReadLine();

                Console.Write("Please enter the patient Medical Aid: ");
                String MedicalAid = Console.ReadLine();

                Console.Write("Please enter the patient's Docter name: ");
                String RefDr = Console.ReadLine();

                Console.Write("Please enter the patient blood type: ");
                char BloodType = Convert.ToChar(Console.ReadLine());

                Console.Write("Please enter any allergies patient has: ");
                String Allergies = Console.ReadLine();

                Console.Write("Please enter if the patient is Covid Positive (True/ Flase) :  ");
                Boolean CovidPositive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Please enter if the patient's has had any vaccine: ");
                String strVac = Console.ReadLine();

               // i.addPerson(ID_Number, Name, Surname, MedicalAid, RefDr, BloodType, Allergies, CovidPositive, strVac);
            }
            
        }
    }
}
    