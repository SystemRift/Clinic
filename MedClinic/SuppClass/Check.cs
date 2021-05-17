using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MedClinic.SuppClass
{
    class Check
    {
        public string SymCheck(string a)
        {
            bool i;
            string b = "", s = "";
            Regex r = new Regex(@"[абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ]");
            Regex g = new Regex(@"[/,.!@#$%^&*()+=№;:?`'~]");
            Regex с = new Regex(@"[ ]");
            Match m = r.Match(a);
            Match x = g.Match(a);
            Match f = с.Match(a);

            if (m.Success)
            {
                //MessageBox.Show("В поле логин нельзя использовать русские буквы");
                s += Convert.ToString(1);
            }

            if (x.Success)
            {
                //MessageBox.Show("В поле логин нельзя использовать специальные символы и пробел");
                s += Convert.ToString(2);
            }

            if (f.Success)
            {
                //MessageBox.Show("В поле логин нельзя использовать специальные символы и пробел");
                s += Convert.ToString(3);
            }

            if (i = s.Contains("1") == true)
            {
                b += "      -русские буквы\n";
            }

            if (i = s.Contains("2") == true)
            {
                b += "      -специальные символы\n";
            }

            if (i = s.Contains("3") == true)
            {
                b += "      -пробел\n";
            }

            return b;
        }

    }
}
