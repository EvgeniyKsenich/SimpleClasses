using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Patient
    {
        protected string surname;
        protected string name;
        protected string second_name;
        protected string adres;
        protected int curt_number;
        protected string diagnosis;
        protected int birth_year;
        public Patient()
        {
            surname="none";
            name = "none";
            second_name = "none"; 
            adres = "none";
            curt_number = 0; 
            diagnosis = "none";
            birth_year = 1000;
        }
        public Patient(string _surname, string _name, string _second_name, string _adres, int _curt_number, string _diagnosis, int _birth_year)
        {
            surname = _surname;
            name = _name;
            second_name = _second_name;
            adres = _adres;
            curt_number = _curt_number;
            diagnosis = _diagnosis;
            birth_year = _birth_year;
        }
        public Patient(Patient x)
        {
            surname = x.surname;
            name = x.name;
            second_name = x.second_name;
            adres = x.adres;
            curt_number = x.curt_number;
            diagnosis = x.diagnosis;
            birth_year = x.birth_year;
        }
        public int Birth_year
        {
            set { birth_year = value; }
            get { return birth_year; }
        }
        public string Diagnosis
        {
            set { diagnosis = value; }
            get { return diagnosis; }
        }
        public int Curt_number
        {
            set { curt_number = value; }
            get { return curt_number; }
        }
        public string Adres
        {
            set { adres = value; }
            get { return adres; }
        }
        public string Second_name
        {
            set { second_name = value; }
            get { return second_name; }
        }
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
