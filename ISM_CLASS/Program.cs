using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            ReadFromFiles READ = new ReadFromFiles();

            //DemoFone();
            //DemoStudent();
            //DemoPatient();


            //Phone[] pt = READ.ReadPhone(@"F:\tmp\st_pt\Phone.txt");
            //for (int i = 0; i < pt.Length; i++)
            //{
            //    WritePhone(pt[i]);
            //    Console.WriteLine();
            //}
            //Phone[] pt1 = READ.SerchPhoneName(pt, "Іван");
            //for (int i = 0; i < pt1.Length; i++)
            //{
            //    WritePhone(pt1[i]);
            //    Console.WriteLine();
            //}

            //Patient[] pt = READ.ReadPatient(@"F:\tmp\st_pt\Patient.txt");
            //for (int i = 0; i < pt.Length; i++)
            //{
            //    WritePatient(pt[i]);
            //    Console.WriteLine();
            //}


            //Student[] pt = READ.ReadStudent(@"F:\tmp\st_pt\student.txt");
            //for(int i=0;i<pt.Length;i++)
            //{
            //    WriteStident(pt[i]);
            //    Console.WriteLine();
            //}

            //Student a = new Student();
            //a.CURS = "3";
            //a.SetAdres = "123 Main st.";
            //string adre = a.GetAdr;
            ////Console.WriteLine(adre);
            //a.Reserv_Name = "Jon";
            //Console.WriteLine(a.Reserv_Name);





            //Worker wr = new Worker("Ivan", "Ivanov", "Ivanovich", "01.01.1998", "st. Chudnivska 193B", "0964000000", "FIKT","ZTU", 97);
            //wr.Print();
            //wr.SetAllDefault();
            //Console.WriteLine();
            //wr.Print();
            //wr.Uneversity = "ZTU";
            //wr.SetMidMark(91);
            //Console.WriteLine();
            //Console.WriteLine("Mid Mark = "+wr.GetMidMark()+"\n"+"University: "+wr.Uneversity);

            //Healthy hl = new Healthy();
            //hl.Print();
            //hl.Adres = "main st.21";
            //hl.Diagnosis = "hadeick";
            //hl.SetDay(21);
            //hl.Surname = "Petrovich";
            //Console.WriteLine();
            //hl.Print();
            //hl.SetAllDefault();
            //Console.WriteLine();
            //hl.Print();

            Illnes il = new Illnes("Ivanov","Ivan","Ivanovich","12 main st.",123, "hadeick",1990, "Andriy Ivanovich", 21);
            il.Print();
            Console.WriteLine();
            il.Print();
            Console.WriteLine();
            il.Decrement_Visitors();
            il.Print();
            Console.WriteLine();
            il.SetAllDefault();
            il.Print();


            //Roaming rm = new Roaming();
            //rm.Print();
            //rm.SetNewMaxRouming(200);
            //rm.SetNewTarif(100);
            //rm.Name = "Sasha";
            //rm.AddInRouming(10);
            //rm.AddInUsed(20);
            //Console.WriteLine();
            //rm.Print();
            //rm.NewMonth();
            //Console.WriteLine();
            //rm.Print();
        }
        static void DemoFone()
        {
            Phone ph1 = new Phone();
            Console.WriteLine("1)Default counstructor");
            WritePhone(ph1);
            Phone ph2 = new Phone("Ivanov","Ivan","Ivanovich","Chudnivska 103b", "+380900000000",7,1,"Kievstar");
            Console.WriteLine();
            Console.WriteLine("2)Parametr counstructor");
            WritePhone(ph2);
            Phone ph3 = new Phone(ph2);
            Console.WriteLine();
            Console.WriteLine("3)Copy (2) counstructor");
            WritePhone(ph3);
            ph1 = DemoPhone("Ivanov", "Ivan", "Ivanovich", "Chudnivska 103b", "+380900000000", 7, 1, "Kievstar");
            Console.WriteLine();
            Console.WriteLine("4)Set value to (1)");
            WritePhone(ph1);
        }
        static Phone DemoPhone(string _surname, string _name, string _second_name, string _adres, string _fone_number, double _in_syti, double _out_syti, string _m_operator)
        {
            Phone x = new Phone();
            x.Surname = _surname;
            x.Name = _name;
            x.Second_name = _second_name;
            x.Adres = _adres;
            x.Fone_number = _fone_number;
            x.In_syti = _in_syti;
            x.Out_syti = _out_syti;
            x.M_operator = _m_operator;
            return x;
        }
        static void WritePhone(Phone p)
        {
            Console.WriteLine("Surname:" + p.Surname);
            Console.WriteLine("Name:" + p.Name);
            Console.WriteLine("SecondName:" + p.Second_name);
            Console.WriteLine("Adres:" + p.Adres);
            Console.WriteLine("Fone:" + p.Fone_number);
            Console.WriteLine("In syti call:" + p.In_syti);
            Console.WriteLine("Out syti call:" + p.Out_syti);
            Console.WriteLine("Operator:" + p.M_operator);
        }
        static void DemoPatient()
        {
            Patient p1 = new Patient();
            Patient p2 = new Patient("Ivanov","Ivan","Ivanovich", "Chudnivska 103b", 1,"Prostuda", 1998);
            Patient p3 = new Patient(p2);
            Console.WriteLine("1)Default counstructor");
            WritePatient(p1);
            Console.WriteLine();
            Console.WriteLine("2)Parametr counstructor");
            WritePatient(p2);
            Console.WriteLine();
            Console.WriteLine("3)Copy (2)");
            WritePatient(p3);
            p1 = SetPatient("Ivanov", "Ivan", "Ivanovich", "Chudnivska 103b", 1, "Prostuda", 1998);
            Console.WriteLine();
            Console.WriteLine("4)Set value to (1)");
            WritePatient(p1);
        }
        static Patient SetPatient(string _surname, string _name, string _second_name, string _adres, int _curt_number, string _diagnosis, int _birth_year)
        {
            Patient tmp = new Patient();
            tmp.Surname = _surname;
            tmp.Name = _name;
            tmp.Second_name = _second_name;
            tmp.Adres = _adres;
            tmp.Curt_number = _curt_number;
            tmp.Diagnosis = _diagnosis;
            tmp.Birth_year = _birth_year;
            return tmp;
        }
        static void WritePatient(Patient p)
        {
            Console.WriteLine("Surname:" + p.Surname);
            Console.WriteLine("Name:" + p.Name);
            Console.WriteLine("SecondName:" + p.Second_name); 
            Console.WriteLine("Adres:" + p.Adres);
            Console.WriteLine("Cart Number:" + p.Curt_number);
            Console.WriteLine("Diagnosis:" + p.Diagnosis);
            Console.WriteLine("Birth year:" + p.Birth_year);
        }
        static void DemoStudent()
        {
            Student st1 = new Student();
            Student st2 = new Student("Ivan", "Ivanov", "Ivanovich", "01.01.1998", "st. Chudnivska 193B", "0964000000", "FIKT", "2");
            Student st3 = new Student(st2);
            Console.WriteLine("1)Standart:");
            WriteStident(st1);
            Console.WriteLine();
            Console.WriteLine("2)Parametr:");
            WriteStident(st2);
            Console.WriteLine();
            Console.WriteLine("3)Copy 3:");
            WriteStident(st3);
            Console.WriteLine();
            st1 = SetStudent("Ivan", "Ivanov", "Ivanovich", "01.01.1998", "st. Chudnivska 193B", "0964000000", "FIKT", "2");
            Console.WriteLine("4)Set (1) by parametr:");
            WriteStident(st1);
        }
        static void WriteStident(Student st)
        {
            Console.WriteLine("Name:" + st.GetName());
            Console.WriteLine("Surname:" + st.GetSurname());
            Console.WriteLine("SecondName:" + st.GetSecondName());
            Console.WriteLine("Birth date:" + st.GetBirthDate());
            Console.WriteLine("Adres:" + st.GetAdress());
            Console.WriteLine("Fone:" + st.GetFone());
            Console.WriteLine("Facultet:" + st.GetFacultet());
            Console.WriteLine("Curs:" + st.GetCurs());
        }
        static Student SetStudent(string _Name, string _SurName, string _SecondName, string _BirthDate, string _Adress, string _Fone, string _Facult, string _Curs)
        {
            Student tmp = new Student();
            tmp.SetName(_Name);
            tmp.SetSurname(_SurName);
            tmp.SetSecondName(_SecondName);
            tmp.SetBirthDate(_BirthDate);
            tmp.SetAdress(_Adress);
            tmp.SetFone(_Fone);
            tmp.SetFacultet(_Facult);
            tmp.SetCurs(_Curs);
            return tmp;
        }
    }
}
