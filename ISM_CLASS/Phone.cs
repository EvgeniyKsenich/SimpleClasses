using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Phone
    {
        protected string surname;
        protected string name;
        protected string second_name;
        protected string adres;
        protected string fone_number;
        protected double in_syti;
        protected double out_syti;
        protected string m_operator;
        public Phone()
        {
        surname = "None";
        name = "None";
        second_name = "None";
        adres = "None";
        fone_number = "None";
        in_syti = 0;
        out_syti = 0;
        m_operator = "None";
        }
        public Phone(string _surname, string _name, string _second_name, string _adres, string _fone_number, double _in_syti, double _out_syti, string _m_operator)
        {
            surname = _surname;
            name = _name;
            second_name = _second_name;
            adres= _adres;
            fone_number = _fone_number;
            in_syti = _in_syti;
            out_syti = _out_syti;
            m_operator = _m_operator;
        }
        public Phone(Phone x)
        {
            surname = x.surname;
            name = x.name;
            second_name = x.second_name;
            adres = x.adres;
            fone_number = x.fone_number;
            in_syti = x.in_syti;
            out_syti = x.out_syti;
            m_operator = x.m_operator;
        }
        public string M_operator
        {
            set { m_operator = value; }
            get { return m_operator; }
        }
        public double Out_syti
        {
            set { out_syti = value; }
            get { return out_syti; }
        }
        public double In_syti
        {
            set { in_syti = value; }
            get { return in_syti; }
        }
        public string Fone_number
        {
            set { fone_number = value; }
            get { return fone_number; }
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
