using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Employee
    {
        string _name;
        string _surname;
        double _salary; 
        public string Name
        {
            get { return _name; }
            set 
            {
                int sayDig = 0;
                int saySym=0;
                int sayUp_1st = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value.Trim()[0]))
                    {
                        sayUp_1st++;
                    }
                    else if (char.IsDigit(value.Trim()[i]))
                    {
                        sayDig++;
                    }
                    else if (char.IsSymbol(value.Trim()[i]))
                    {
                        saySym++;
                    }
                }
                if (sayUp_1st == 1 && sayDig == 0 && saySym == 0 && value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Adiniz sertlere uygun deyilduzgun daxil edin:");
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                int sayDig = 0;
                int saySym = 0;
                int sayUp_1st = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value.Trim()[0]))
                    {
                        sayUp_1st++;
                    }
                    else if (char.IsDigit(value.Trim()[i]))
                    {
                        sayDig++;
                    }
                    else if (char.IsSymbol(value.Trim()[i]))
                    {
                        saySym++;
                    }
                }
                if (sayUp_1st == 1 && sayDig == 0 && saySym == 0 && value.Length > 2)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Soyadiniz sertlere uygun deyil duzgun daxil edin:");
                }
            }
        }
        public double Salary
        {
            get { return _salary;}
            set
            {
                if (value >= 250) { _salary = value; }
                else { Console.WriteLine("Salary azdir:"); }
            }
        }

    }
}
