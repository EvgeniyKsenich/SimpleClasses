using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Illnes:Patient
    {
        protected string doctor_name;
        protected int visitors_cout;

        public Illnes():base()
        {
            SetDefault();
        }
        public Illnes(string _surname, string _name, string _second_name, string _adres, int _curt_number, string _diagnosis, int _birth_year,
            string doctor_name, int visitors_cout) : base(_surname, _name, _second_name, _adres, _curt_number, _diagnosis, _birth_year)
        {
            this.doctor_name = doctor_name;
            this.visitors_cout = visitors_cout;
        }

        public string Doctore_name
        {
            get { return doctor_name; }
            set { doctor_name = value; }
        }
        public int Visitors
        {
            get { return visitors_cout; }
            set { visitors_cout = value; }
        }

        public void Increment_Visitors()
        {
            visitors_cout++;
        }
        public void Decrement_Visitors()
        {
            visitors_cout--;
        }
        protected void SetDefault()
        {
            doctor_name = "None";
            visitors_cout = 0;
        }




        public override void Print()
        {
            base.Print();
            Console.WriteLine("Doctor name: " + doctor_name);
            Console.WriteLine("Day in hospital: " + visitors_cout);
        }
        public override void SetAllDefault()
        {
            base.SetAllDefault();
            SetDefault();
        }
    }
}
