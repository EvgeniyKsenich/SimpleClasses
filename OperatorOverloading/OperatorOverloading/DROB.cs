using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class DROB
    {
        int ch;
        int zn;
        public DROB() { ch = 1; zn = 1; }
        public DROB(int ch, int zn) { this.ch = ch; this.zn = zn; Scorot(); }
        public DROB(int x) { ch = x; zn = 1; }

        public int numerator
        {
            get { return ch; }
            set { ch = value; }
        }

        public int denominator
        {
            get { return zn; }
            set { if(value!=0)zn = value; }
        }

        protected void Scorot()
        {
            double bb;
            if (ch > zn) bb = zn;
            else bb = ch;
            for (int i = 2; i < zn + 1; i++)
            {
                if (ch % i == 0 && zn % i == 0)
                {
                    ch /= i;
                    zn /= i;
                    i = 2;
                }
            }
        }
        public static DROB operator +(DROB a, DROB b)
        {
            DROB tmp = new DROB();
            if (a.denominator == b.denominator)
            {
                tmp.numerator = a.numerator + b.numerator;
                tmp.denominator = a.denominator;
            }
            else
            {
                tmp.numerator = (a.numerator * b.denominator) + (b.numerator * a.denominator);
                tmp.denominator = (a.denominator * b.denominator);
            }
            tmp.Scorot();
            return tmp;
        }
        public static DROB operator +(DROB a, int b)
        {
            DROB tmp = new DROB();
            tmp.numerator = a.numerator + b* a.denominator;
            tmp.denominator = a.denominator;
            tmp.Scorot();
            return tmp;
        }

        public static DROB operator -(DROB a, DROB b)
        {
            DROB tmp = new DROB();
            if (a.denominator == b.denominator)
            {
                tmp.numerator = a.numerator - b.numerator;
                tmp.denominator = a.denominator;
            }
            else
            {
                tmp.numerator = (a.numerator * b.denominator) - (b.numerator * a.denominator);
                tmp.denominator = (a.denominator * b.denominator);
            }
            tmp.Scorot();
            return tmp;
        }
        public static DROB operator -(DROB a, int b)
        {
            DROB tmp = new DROB();
            tmp.numerator = a.numerator - b * a.denominator;
            tmp.denominator = a.denominator;
            tmp.Scorot();
            return tmp;
        }

        public static DROB operator -(DROB a)
        {
            DROB tmp = new DROB();
            tmp.numerator = -a.numerator;
            tmp.denominator = a.denominator;
            tmp.Scorot();
            return tmp;
        }

        public static DROB operator *(DROB a, DROB b)
        {
            DROB tmp = new DROB();
            tmp.numerator = a.numerator * b.numerator;
            tmp.denominator = a.denominator * b.denominator;
            tmp.Scorot();
            return tmp;
        }
        public static DROB operator *(DROB a, int b)
        {
            DROB tmp = new DROB();
            DROB _b = new DROB(b);
            return (a*_b);
        }

        public static DROB operator /(DROB a, DROB b)
        {
            DROB tmp = new DROB();
            int t = b.numerator;
            b.numerator = b.denominator;
            b.denominator = t;
            tmp = a * b;
            return tmp;
        }
        public static DROB operator /(DROB a, int b)
        {
            DROB tmp = new DROB();
            DROB _b = new DROB(b);
            return (a / _b);
        }
        public static implicit operator double(DROB a)
        {
            return ((1.0)*a.ch/a.zn);
        }

        public static bool operator >(DROB a, DROB b)
        {
            double _a = a;
            double _b = b;
            return (_a > _b);
        }
        public static bool operator >(DROB a, int b)
        {
            double _a = a;
            DROB _b = new DROB(b);
            double _c = _b;
            return (_a > _c);
        }
        public static bool operator >(DROB a, double b)
        {
            double _a = a;
            return (_a > b);
        }



        public static bool operator <(DROB a, DROB b)
        {
            return !(a>b);
        }
        public static bool operator <(DROB a, int b)
        {
            double _a = a;
            DROB _b = new DROB(b);
            double _c = _b;
            return !(_a > _c);
        }
        public static bool operator <(DROB a, double b)
        {
            double _a = a;
            return (_a < b);
        }



        public static bool operator ==(DROB a, DROB b)
        {
            double _a = a;
            double _b = b;
            return (_a == _b);
        }
        public static bool operator ==(DROB a, int b)
        {
            double _a = a;
            return (_a == b);
        }
        public static bool operator ==(DROB a, double b)
        {
            double _a = a;
            return (_a == b);
        }


        public static bool operator !=(DROB a, DROB b)
        {
            return !(a == b);
        }
        public static bool operator !=(DROB a, int b)
        {
            return !(a == b);
        }
        public static bool operator !=(DROB a, double b)
        {
            return !(a == b);
        }



        public static bool operator >=(DROB a, DROB b)
        {
            return (a>b || a==b);
        }
        public static bool operator >=(DROB a, int b)
        {
            return (a > b || a == b);
        }
        public static bool operator >=(DROB a, double b)
        {
            return (a > b || a == b);
        }


        public static bool operator <=(DROB a, DROB b)
        {
            return (a < b || a == b);
        }
        public static bool operator <=(DROB a, int b)
        {
            return (a < b || a == b);
        }
        public static bool operator <=(DROB a, double b)
        {
            return (a < b || a == b);
        }



        public void Write()
        {
            Console.Write("("+ch+"/" + zn+")");
        }
        public string Drob
        {
            get { return ("(" + ch + "/" + zn + ")"); }
        }
        public int SG_Drob
        {
            set { ch = value;zn = 1; }
        }
        
}
}
