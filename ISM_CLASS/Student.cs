using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Student
    {
        protected string Name;
        protected string SurName;
        protected string SecondName;
        protected string BirthDate;
        protected string Adress;
        protected string Fone;
        protected string Facult;
        protected string Curs;
        //.........(2.0)..........//
        public string CURS
        {
            get { return Curs; }
            set {
                if (int.Parse(value) > 0 && int.Parse(value) <= 5)Curs = value;
                }
        }

        public string Reserv_Name { get; set; }


        public string GetAdr
        {
            get { return Adress; }
        }
        public string SetAdres
        {
            set { Adress = value; }
        } 


       //........................//
        public Student()
        {
            Name = "None_Name";
            SurName = "None";
            SecondName = "None";
            BirthDate = "None";
            Adress = "None";
            Fone = "None";
            Facult = "None";
            Curs = "None";
    }

        public Student(string _Name, string _SurName, string _SecondName, string _BirthDate, string _Adress, string _Fone, string _Facult, string _Curs)
        {
            Name = _Name;
            SurName = _SurName;
            SecondName = _SecondName;
            BirthDate = _BirthDate;
            Adress = _Adress;
            Fone = _Fone;
            Facult = _Facult;
            Curs = _Curs;
        }
        public Student(Student nw)
        {
            Name = nw.Name;
            SurName = nw.SurName;
            SecondName = nw.SecondName;
            BirthDate = nw.BirthDate;
            Adress = nw.Adress;
            Fone = nw.Fone;
            Facult = nw.Facult;
            Curs = nw.Curs;
        }
        public void SetName(string NAME)
        {
            Name = NAME;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetSurname(string surname)
        {
            SurName = surname;
        }
        public string GetSurname()
        {
            return SurName;
        }
        public void SetSecondName(string secondname)
        {
            SecondName = secondname;
        }
        public string GetSecondName()
        {
            return SecondName;
        }
        public void SetBirthDate(string date)
        {
            BirthDate = date;
        }
        public string GetBirthDate()
        {
            return BirthDate;
        }
        public void SetAdress(string adres)
        {
            Adress = adres;
        }
        public string GetAdress()
        {
            return Adress;
        }
        public void SetFone(string fone)
        {
            Fone = fone;
        }
        public string GetFone()
        {
            return Fone;
        }
        public void SetFacultet(string facultet)
        {
            Facult = facultet;
        }
        public string GetFacultet()
        {
            return Facult;
        }
        public void SetCurs(string curs)
        {
            Curs = curs;
        }
        public string GetCurs()
        {
            return Curs;
        }
    }
}
