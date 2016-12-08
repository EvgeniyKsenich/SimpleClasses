using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class OperatorOverloading
    {
        int ch;
        int zn;
        public OperatorOverloading() { ch = 1; zn = 1; }
        public OperatorOverloading(int ch, int zn) { this.ch = ch; this.zn = zn; Scorot(); }
        public OperatorOverloading(int x) { ch = x; zn = 1; }

        protected void Scorot()
        {
            int bb;
            if (ch > zn) bb = zn;
            else bb = ch;
            for(int i=2;i< zn;i++)
            {
                if(ch % i ==0 && zn % i==0)
                {
                    ch /= i;
                    zn /= i;
                    i = 2;
                }
            }
        }
    }
}
