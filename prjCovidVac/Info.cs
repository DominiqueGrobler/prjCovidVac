using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class Info
    {
        //Special Student Variable
        private static int iSizeArray = 0;
        private static int iCounter = 0;

        private static String strHospital_Name;
        private static String strAddress;
        private static bool bType;
        private static char cProvince;

        #region gets and sets

        public void setHospital_Name(String hospitalName)
        {
            strHospital_Name = hospitalName;
        }

        public String getHospital_Name()
        {
            return strHospital_Name;
        }

        public void setAddress(String address)
        {
            strAddress = address;
        }

        public String getAddress()
        {
            return strAddress;
        }

        public void setHospitalType(Boolean Type)
        {
            bType = Type;
        }

        public Boolean getHospitalType()
        {
            return bType;
        }

        public void setProvince(Char province)
        {
            cProvince = province;
        }

        public Char getProvince()
        {
            return cProvince;
        }
        #endregion

        #region arrays
        private static String[] ID_Number;
        private static String[] MedicalAid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static Char[] BloodType;
        private static String[] Allergies;
        private static Boolean[] CovidPositive;
        private static String[] Vaccine;
        #endregion

        #region setting arrays 
        public void setArray(int num)
        {
            ID_Number = new String[num];
            MedicalAid = new String[num];
            Name = new String[num];
            Surname = new String[num];
            RefDr = new String[num];
            BloodType = new Char[num];
            Allergies = new String[num];
            CovidPositive = new Boolean[num];
            Vaccine = new String[num];
            iSizeArray = num;
        }
        #endregion

        #region adding a person
        public void addPerson(String strID, String strMedic, String strName,
            String strSuranme, String strRefDr, Char cBloodType,
            String strAllergies, Boolean bCovid, String strVac)
        {

            ID_Number[iCounter] = strID;
            MedicalAid[iCounter] = strMedic;
            Name[iCounter] = strName;
            Surname[iCounter] = strSuranme;
            RefDr[iCounter] = strRefDr;
            BloodType[iCounter] = cBloodType;
            Allergies[iCounter] = strAllergies;
            CovidPositive[iCounter] = bCovid;
            Vaccine[iCounter] = strVac;

            iCounter++;
        }
        #endregion

        public int size()
        {
            return iSizeArray;
        }

        public String getIDNumber(int x)
        {
            return ID_Number[x];
        }

        public String getName(int x)
        {
            return Name[x];
        }

        public String getSurame(int x)
        {
            return Surname[x];
        }

        public String getRefDr(int x)
        {
            return RefDr[x];
        }
        public Char getBloodType(int x)
        {
            return BloodType[x];
        }
        public String getAllergies(int x)
        {
            return Allergies[x];
        }
        public Boolean getBCovid(int x)
        {
            return CovidPositive[x];
        }
        public String getVaccine(int x)
        {
            return Vaccine[x];
        }
    }
}
