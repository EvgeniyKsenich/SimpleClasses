using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            DROB db = new DROB(3,4);
            DROB dc = new DROB(3,4);
            DROB db1 = new DROB(3,5);
            DROB db2 = db + db1;
            Console.Write(db.Drob +"+"+ db1.Drob+"=");
            db2 = db + db1;
            db2.Write();
            Console.WriteLine();
            Console.Write(db.Drob + "+" + "2" + "=");
            db2 = db + 2;
            db2.Write();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(db.Drob + "-" + db1.Drob + "=");
            db2 = db - db1;
            db2.Write();
            Console.WriteLine();
            Console.Write(db.Drob + "-" + "2" + "=");
            db2 = db - 2;
            db2.Write();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(db.Drob + "*" + db1.Drob + "=");
            db2 = db * db1;
            db2.Write();
            Console.WriteLine();
            Console.Write(db.Drob + "*" + "2" + "=");
            db2 = db * 2;
            db2.Write();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(db.Drob + "/" + db1.Drob + "=");
            db2 = db / db1;
            db2.Write();
            Console.WriteLine();
            Console.Write(db.Drob + "/" + "2" + "=");
            db2 = db / 2;
            db2.Write();
            Console.WriteLine();

            Console.WriteLine();
            double d = db;
            Console.Write(db.Drob + " to double = "+ d);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write(db.Drob + ">" + db1.Drob +" = ");
            if (db > db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.Write(db.Drob + ">" + 2 + " = ");
            if (db > 2) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();


            Console.Write(db.Drob + "<" + db1.Drob + " = ");
            if (db < db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.Write(db.Drob + "<" + 2 + " = ");
            if (db < 2) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.WriteLine();



            Console.Write(db.Drob + "==" + db1.Drob + " = ");
            if (db == db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.Write(db.Drob + "==" + "(0.75)" + " = ");
            if (db == 0.75) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.Write(db.Drob + "==" + "(1)" + " = ");
            if (db == 1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();

            Console.Write(db.Drob + "!=" + db1.Drob + " = ");
            if (db != db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();

            Console.Write(db.Drob + "==" + dc.Drob + " = ");
            if (db == dc) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();


            Console.Write(db.Drob + ">=" + db1.Drob + " = ");
            if (db >= db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();
            Console.Write(db.Drob + "<=" + db1.Drob + " = ");
            if (db <= db1) Console.Write("true");
            else Console.Write("false");
            Console.WriteLine();

            Console.Write(db.Drob+" |" +"-" +db.Drob+" = ");
            db = -db;
            db.Write();
            Console.WriteLine();
            Console.Write(db.Drob + " |" + "-" + db.Drob + " = ");
            db = -db;
            db.Write();
            Console.WriteLine();


        }
    }
}
