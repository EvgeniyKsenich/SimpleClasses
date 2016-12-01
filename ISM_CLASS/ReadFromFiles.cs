using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ISM_CLASS
{
    class ReadFromFiles
    {
        Regex R_Student = new Regex(@"([A-Za-zА-Яфа-яІіЇїЄє]+)\s+([A-Za-zА-Яфа-яІіЇїЄє]+)\s*([A-Za-zА-Яфа-яІіЇїЄє]+)\s*(\s*(?:[\d\.]+)\s)(.+)\+?(\d{10,12})\s+([A-Za-zА-Яфа-яІіЇїЄє]+)\s+(\d+)\s?");
        Regex R_Patient = new Regex(@"([A-Za-zА-Яфа-яІіЇїЄє]+)\s+([A-Za-zА-Яфа-яІіЇїЄє]+)\s*([A-Za-zА-Яфа-яІіЇїЄє]+)\s*(.+)\s(\d+)\s+([A-Za-zА-Яфа-яІіЇїЄє]+)\s+(\d+)");
        Regex R_Phone = new Regex(@"([A-Za-zА-Яфа-яІіЇїЄє]+)\s+([A-Za-zА-Яфа-яІіЇїЄє]+)\s*([A-Za-zА-Яфа-яІіЇїЄє]+)\s*(.+)\s(\d+)\s+(\d+\.?,?(?:\d+)?)\s+(\d+\.?,?(?:\d+)?)\s+([A-Za-zА-Яфа-яІЇЄїіє]+)");

        public Student[] SerchStudent_by_Facult(Student[] Ph, string Facult)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetFacultet() == Facult) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetFacultet() == Facult) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_Curs(Student[] Ph, string Curs)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetCurs() == Curs) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetCurs() == Curs) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_Phone(Student[] Ph, string Fone)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetFone() == Fone) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetFone() == Fone) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_Adress(Student[] Ph, string Adress)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetAdress() == Adress) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetAdress() == Adress) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_BirthDate(Student[] Ph, string BirthDate)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetBirthDate() == BirthDate) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetBirthDate() == BirthDate) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_SecondName(Student[] Ph, string SecondName)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetSecondName() == SecondName) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetSecondName() == SecondName) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_SurName(Student[] Ph, string SurName)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetSurname() == SurName) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetSurname() == SurName) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Student[] SerchStudent_by_Name(Student[] Ph, string Name)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].GetName() == Name) lic++;
            Student[] tmp = new Student[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Student();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].GetName() == Name) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }


        public Patient[] SerchPatient_by_Birth_year(Patient[] Ph, int birth_year)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Birth_year == birth_year) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Birth_year == birth_year) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_Diagnosis(Patient[] Ph, string diagnosis)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Diagnosis == diagnosis) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Diagnosis == diagnosis) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_Curt_number(Patient[] Ph, int curt_number)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Curt_number == curt_number) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Curt_number == curt_number) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_Adres(Patient[] Ph, string adres)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Adres == adres) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Adres == adres) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_SecondName(Patient[] Ph, string second_name)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Second_name == second_name) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Second_name == second_name) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_SurName(Patient[] Ph, string surname)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Surname == surname) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Surname == surname) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Patient[] SerchPatient_by_Name(Patient[] Ph, string Name)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Name == Name) lic++;
            Patient[] tmp = new Patient[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Patient();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Name == Name) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }


        public Phone[] SerchPhoneName(Phone[] Ph, string Name)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Name == Name) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Name == Name) { tmp[i1] = Ph[i];i1++; };
            return tmp;
        }

        public Phone[] SerchPhoneSurName(Phone[] Ph, string SurName)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Surname == SurName) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Surname == SurName) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }

        public Phone[] SerchPhoneSecond(Phone[] Ph, string Secondname)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Second_name == Secondname) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Second_name == Secondname) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }

        public Phone[] SerchPhoneAdres(Phone[] Ph, string Adres)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Adres == Adres) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Adres == Adres) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Phone[] SerchPhonePhoneAdres(Phone[] Ph, string FAdres)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].Fone_number == FAdres) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].Fone_number == FAdres) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Phone[] SerchPhoneBy_in_syti(Phone[] Ph, int in_syti)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].In_syti == in_syti) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].In_syti == in_syti) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }
        public Phone[] SerchPhone_by_operator(Phone[] Ph, string Operator)
        {
            int lic = 0;
            for (int i = 0; i < Ph.Length; i++) if (Ph[i].M_operator == Operator) lic++;
            Phone[] tmp = new Phone[lic];
            for (int i = 0; i < lic; i++) tmp[i] = new Phone();
            for (int i = 0, i1 = 0; i < Ph.Length; i++) if (Ph[i].M_operator == Operator) { tmp[i1] = Ph[i]; i1++; };
            return tmp;
        }

        public Phone[] ReadPhone(string path)
        {
            string all = Read(path);
            MatchCollection tm = R_Phone.Matches(all);
            Phone[] tmp = new Phone[tm.Count];
            for (int i = 0; i < tm.Count; i++) tmp[i] = new Phone();
            for (int i = 0; i < tm.Count; i++)
            {
                tmp[i].Surname = tm[i].Groups[1].Value;
                tmp[i].Name = tm[i].Groups[2].Value;
                tmp[i].Second_name = tm[i].Groups[3].Value;
                tmp[i].Adres = tm[i].Groups[4].Value;
                tmp[i].Fone_number = tm[i].Groups[5].Value;
                tmp[i].In_syti = double.Parse(tm[i].Groups[6].Value);
                tmp[i].Out_syti = double.Parse(tm[i].Groups[7].Value);
                tmp[i].M_operator = tm[i].Groups[8].Value;
            }
            return tmp;
        }
        public Patient[] ReadPatient(string path)
        {
            string all = Read(path);
            MatchCollection tm = R_Patient.Matches(all);
            Patient[] tmp = new Patient[tm.Count];
            for (int i = 0; i < tm.Count; i++) tmp[i] = new Patient();
            for (int i = 0; i < tm.Count; i++)
            {
                tmp[i].Surname = tm[i].Groups[1].Value;
                tmp[i].Name = tm[i].Groups[2].Value;
                tmp[i].Second_name = tm[i].Groups[3].Value;
                tmp[i].Adres = tm[i].Groups[4].Value;
                tmp[i].Curt_number = int.Parse(tm[i].Groups[5].Value);
                tmp[i].Diagnosis = tm[i].Groups[6].Value;
                tmp[i].Birth_year = int.Parse(tm[i].Groups[7].Value);
            }
            return tmp;
        }
        public Student[] ReadStudent(string path)
        {
            string all = Read(path);
            MatchCollection tm = R_Student.Matches(all);
            Student[] tmp = new Student[tm.Count];
            for (int i = 0; i < tm.Count; i++) tmp[i] = new Student();
            for (int i=0;i<tm.Count;i++)
            {
                tmp[i].SetSurname(tm[i].Groups[1].Value);
                tmp[i].SetName(tm[i].Groups[2].Value);
                tmp[i].SetSecondName(tm[i].Groups[3].Value);
                tmp[i].SetBirthDate(tm[i].Groups[4].Value);
                tmp[i].SetAdress(tm[i].Groups[5].Value);
                tmp[i].SetFone(tm[i].Groups[6].Value);
                tmp[i].SetFacultet(tm[i].Groups[7].Value);
                tmp[i].SetCurs(tm[i].Groups[8].Value);
            }
            return tmp;
        }
        string[] GetMas(string all)
        {
            int cout = 0, lenth = all.Length;
            for (int i = 0; i < lenth; i++)
            {
                if (all[i].ToString() == "\n") cout++;
            }
            cout++;
            string[] mas = new string[cout];
            for (int i = 0, i1 = 0; i < lenth; i++)
            {
                if (all[i].ToString() != "\n") mas[i1] += all[i];
                if (all[i].ToString() == "\n") i1++;
            }
            return mas;
        }
        void write(string path, string file)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(file);
            }
        }
        void write(string path, string[] file)
        {
            string file1 = "";
            for (int i = 0; i < file.Length; i++)
            {
                file1 += file[i] + Environment.NewLine;
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(file1);
            }
        }
        string Read(string path)
        {
            string all = "";
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.GetEncoding(1251)))
                {
                    all = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return all;
        }
    }
}
