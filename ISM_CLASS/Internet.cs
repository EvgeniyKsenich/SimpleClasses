using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Internet:Phone
    {
        protected double tarif;
        protected double used;

        public Internet():base()
        {
            tarif=0;
            used=0;
        }
        public Internet(string _surname, string _name, string _second_name, string _adres, string _fone_number, double _in_syti, double _out_syti, 
            string _m_operator, double tarif, double used):base(_surname, _name, _second_name, _adres, _fone_number, _in_syti, _out_syti, _m_operator)
        {
            this.tarif = tarif;
            this.used = used;
        }

        public double Tarif
        {
            get { return tarif; }
            set { tarif = value; }
        }
        public double Used
        {
            get { return used; }
            set { used = value; }
        }




        public void SetNewTarif(double tar)
        {
            tarif = tar;
        }
        public void ZeroUsed()
        {
            used = 0;
        }
        public void AddInUsed(double ch)
        {
            used += ch;
        }




        public override void NewMonth()
        {
            base.NewMonth();
            used=0;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Tarif:" + tarif);
            Console.WriteLine("Used:" + used);
        }
    }
}
