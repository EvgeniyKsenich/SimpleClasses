using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Roaming:Internet
    {
        protected double maxRoumingMb;
        protected double curent_rouming;

        public Roaming():base()
        {
            maxRoumingMb = 0;
            curent_rouming = 0;
        }

        public Roaming(string _surname, string _name, string _second_name, string _adres, string _fone_number, double _in_syti, double _out_syti,
            string _m_operator, double tarif, double used, double maxRoumingMb, double curent_rouming) : base(_surname, _name, _second_name, _adres, 
                _fone_number, _in_syti, _out_syti, _m_operator, tarif, used)
        {
            this.maxRoumingMb = maxRoumingMb;
            this.curent_rouming = curent_rouming;
        }

        public void AddInRouming(double ch)
        {
            curent_rouming += ch;
        }
        public void ZeroRouming()
        {
            curent_rouming = 0;
        }
        public void SetNewMaxRouming(double rm)
        {
            maxRoumingMb = rm;
        }

        public double Curent
        {
            get { return curent_rouming; }
            set { curent_rouming = value; }
        }


        public override void NewMonth()
        {
            base.NewMonth();
            curent_rouming = 0;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Max rouming:" + maxRoumingMb);
            Console.WriteLine("Used rouming:" + curent_rouming);
        }
    }
}
