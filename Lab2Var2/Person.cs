using System;
using System.Xml.Linq;

namespace Lab2Var2
{
    class Person
    {
        string name;
        int birth_year;
        double pay;
        public Person() // конструктор без параметрів
        {
            name = "Anonimous";
            birth_year = 0;
            pay = 0;
        }
        public Person(string s) // 2 конструктор з параметром
        {
            string[] split = s.Split(new Char[] { '/' });
            name = split[0].Trim();
            birth_year = Convert.ToInt32(split[1].Trim());
            pay = Convert.ToDouble(split[2].Trim());
            if (birth_year < 0) throw new FormatException();
            if (pay < 0) throw new FormatException();
        }
        public override string ToString() // 3 перевизначений метод
        {
            return string.Format($"Name: {name} birth: {birth_year} pay: {pay}");
        }
        public int Compare(string name) // порівняння прізвища
        {
            return (string.Compare(this.name, 0, name, 0, name.Length,
            StringComparison.OrdinalIgnoreCase));
        }
        // -------------------- властивості класу --------------------------
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Birth_year
        {
            get { return birth_year; }
            set
            {
                if (value > 0) birth_year = value;
                else throw new FormatException();
            }
        }
        public double Pay
        {
            get { return pay; }
            set
            {
                if (value > 0) pay = value;
                else throw new FormatException();
            }
        }
        // ------------------ операції класу ---------------------------
        public static double operator +(Person pers, double a)
        {
            pers.pay += a;
            return pers.pay;
        }
        public static double operator +(double a, Person pers)
        {
            pers.pay += a;
            return pers.pay;
        }
        public static double operator -(Person pers, double a)
        {
            pers.pay -= a;
            if (pers.pay < 0) throw new FormatException();
            return pers.pay;
        }
    }
}