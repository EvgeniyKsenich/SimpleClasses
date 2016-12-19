using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Healthy:Patient
    {
        protected string status;
        protected int day_cout;

        public Healthy():base()
        {
            status = "None";
            day_cout = 0;
        }

        public Healthy(string _surname, string _name, string _second_name, string _adres, int _curt_number, string _diagnosis, int _birth_year,
            string _status, int count) : base(_surname, _name, _second_name, _adres, _curt_number, _diagnosis, _birth_year)
        {
            status = _status;
            day_cout = count;
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Day
        {
            get { return day_cout; }
            set { day_cout = value; }
        }
        public int GetDay()
        {
            return day_cout;
        }
        public void SetDay(int day)
        {
            day_cout = day;
        }
        protected void SetDefault()
        {
            status = "None";
            day_cout = 0;
        }




        public override void Print()
        {
            base.Print();
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Day in hospital: " + day_cout);
        }
        public override void SetAllDefault()
        {
            base.SetAllDefault();
            SetDefault();
        }

    }
}
