using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pract8_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"ЭтО just one НебольШой message for простого cheking this проГрамМЫ";
            Console.WriteLine("The original message:\n " + text);
            var newText = Regex.Replace(text, "[абвгдеёжзийклмнопрстуфхцчшщыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЬЭЮЯ]", "");
            Console.WriteLine("Changed message:\n " + newText);
            Console.ReadLine();
        }
    }
}
