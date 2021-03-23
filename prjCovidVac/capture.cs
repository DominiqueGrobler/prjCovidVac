using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class capture
    {
        Info i = new Info();
        //variables to be added to array
        private static String ID_Number;
        private static String MedicalAid;
        private static String Name;
        private static String Surname;
        private static String RefDr;
        private static Char BloodType;
        private static String Allergies;
        private static Boolean CovidPositive;
        private static String Vac;

        public void getPatientDetails()
        {
            Console.Write("Enter the Hospital Name:");
            i.setHospital_Name(Console.ReadLine());

            Console.Write("Is it a Private or Public Hospital:");
            i.setHospitalType(Convert.ToBoolean(Console.ReadLine()));

            Console.Write("Enter the Address:");
            i.setAddress(Console.ReadLine());

            Console.Write("In what Province is the Hospital:");
            i.setProvince(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter the number of patients: ");
            i.setArray(Convert.ToInt32(Console.ReadLine()));

            
            // this is used to loop to the size of the patients you set in array
            for (int x = 0; x < i.size(); x++)// the size is there to see how many patients was entered in the array
            {
                Console.Write("Please enter the patient ID number: ");
                ID_Number = Console.ReadLine();

                Console.Write("Please enter the patient " + (x + 1) + "name: ");
                Name = Console.ReadLine();

                Console.Write("Please enter the patient surname: ");
                Surname = Console.ReadLine();

                Console.Write("Please enter the patient Medical Aid: ");
                MedicalAid = Console.ReadLine();

                Console.Write("Please enter the patient's Docter name: ");
                RefDr = Console.ReadLine();

                Console.Write("Please enter the patient blood type: ");
                BloodType = Convert.ToChar(Console.ReadLine());

                Console.Write("Please enter any allergies patient has: ");
                Allergies = Console.ReadLine();

                Console.Write("Please enter if the patient is Covid Positive (True/ Flase) :  ");
                CovidPositive = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Please enter if the patient's has had any vaccine: ");
                Vac = Console.ReadLine();

                Console.WriteLine("\n");

               i.addPerson(ID_Number, Name, Surname, MedicalAid, RefDr, BloodType, Allergies, CovidPositive, Vac);
            }
            
        }
    }
}
    