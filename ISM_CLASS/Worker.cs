using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Worker:Student
    {
        protected string university;
        protected double mid_mark;

        public Worker():base()
        {
            SetDefault();
        }

        public Worker(string _Name, string _SurName, string _SecondName, string _BirthDate, string _Adress,string _Fone, string _Facult, 
             string _university, double _mid_mark) : base(_Name, _SurName, _SecondName, _BirthDate, _Adress, _Fone, _Facult,"0")
        {
            university = _university;
            mid_mark = _mid_mark;
        }

        public void SetMidMark(double mark)
        {
            mid_mark = mark;
        }
        public double GetMidMark()
        {
            return mid_mark;
        }
        protected void SetDefault()
        {
            university = "None";
            mid_mark = 0;
        }

        public string Uneversity
        {
            get { return university; }
            set { university = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Name:" + base.Name);
            Console.WriteLine("Surname:" + base.SurName);
            Console.WriteLine("SecondName:" + base.SecondName);
            Console.WriteLine("Birth date:" + base.BirthDate);
            Console.WriteLine("Adres:" + base.Adress);
            Console.WriteLine("Fone:" + base.Fone);
            Console.WriteLine("Facultet:" + base.Facult);
            Console.WriteLine("Universiry: " + university);
            Console.WriteLine("Mid marks:" + mid_mark);
        }
        public override void SetAllDefault()
        {
            base.SetAllDefault();
            university = "None";
            mid_mark = 0;
        }
    }
}
