//1 Создать массив строк на 40000 элементов. Заполнить его римскими числами и показать на экран.

//2 Ввести число в диапазоне от 0 до 1000000. Озвучить его словами. Например, при вводе 25 вывести на экран двадцать пять

//3 Дана последовательность 1, 11, 21, 1211, 111221, 312211, 13112221. Ввести число N. Показать N--нный по счёту элемент последовательности

using System.ComponentModel.Design;
using System.Text;
using System.Text.Encodings.Web;

namespace Одномерные_массивы_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            
            Console.OutputEncoding = Encoding.UTF8;

            char[] symbols = { '\u2160', '\u2161', '\u2162', '\u2163', '\u2164', '\u2165', '\u2166', '\u2167', '\u2168', '\u2169', '\u216A', '\u216B', '\u216C', '\u216D', '\u216E', '\u216F' };
            char[] chars = new char[4000];
            UnicodeEncoding enc = new UnicodeEncoding();
            byte[] bytes = enc.GetBytes(symbols);

            char[] decodsymbols = enc.GetChars(bytes);
            foreach (char c in decodsymbols)
                Console.Write(c + " ");
            //2
            //string[] numbers = {"один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять "};
            //string[] tentotwenty = {"одинадцать ", "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ", "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать " };
            //string[] dozens = {"десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто "};
            //string[] hundreds = { "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
            //string[] thousands = { "тысячя ", "две тысячи ", "три тысячи ", "четыре тысячи ", "пять тысяч ", "шесть тысяч ", "семь тысяч ", "восемь тысяч ", "девять тысяч " };
            //string[] tensthousands = { "десять тысяч ", "двадцать тысяч ", "тридцать тысяч ", "сорок тысяч " };

            //uint number = Convert.ToUInt32(Console.ReadLine());

            //string str = "";

            //if (number == 0 || number > 40000) {
            //    str = "ноль";
            //}

            //else if (number >= 10000 && number <= 40000) {
            //    if(number / 1000 % 10 == 0&& number / 100 % 10 == 0 && number / 10 % 10 == 0 && number % 10 == 0){
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];
            //    }
            //    if (number / 100 % 10 == 0 && number / 10 % 10 == 0 && number % 10 == 0)
            //    {
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];

            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];
            //    }

            //    else if (number % 10 == 0 && number / 10 % 10 == 0)
            //    {
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];

            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];
            //    }

            //    else if (number % 10 == 0)
            //    {
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];

            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];
            //    }

            //    else if (number / 10 % 10 == 0)
            //    {
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];

            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }

            //    else
            //    {
            //        if (number / 10000 == 1)
            //            str += tensthousands[0];

            //        else if (number / 10000 == 2)
            //            str += tensthousands[1];

            //        else if (number / 10000 == 3)
            //            str += tensthousands[2];

            //        else
            //            str += tensthousands[3];

            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }

            //}

            //else if (number >= 1000 && number < 10000) {   
            //    if(number / 100 % 10 == 0 && number / 10 % 10 == 0 && number % 10 == 0) {
            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];
            //    }

            //    else if (number % 10 == 0 && number / 10 % 10 == 0)
            //    {
            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];
            //    }

            //    else if (number % 10 == 0)
            //    {
            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];
            //    }

            //    else if (number / 10 % 10 == 0)
            //    {
            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }

            //    else
            //    {
            //        if (number / 1000 == 1)
            //            str += thousands[0];

            //        else if (number / 1000 == 2)
            //            str += thousands[1];

            //        else if (number / 1000 == 3)
            //            str += thousands[2];

            //        else if (number / 1000 == 4)
            //            str += thousands[3];

            //        else if (number / 1000 == 5)
            //            str += thousands[4];

            //        else if (number / 1000 == 6)
            //            str += thousands[5];

            //        else if (number / 1000 == 7)
            //            str += thousands[6];

            //        else if (number / 1000 == 8)
            //            str += thousands[7];

            //        else
            //            str += thousands[8];

            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }
            //}

            //else if (number >= 100 && number < 1000) {
            //    if (number % 10 == 0 && number / 10 % 10 == 0) {
            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];              
            //    }

            //    else if(number % 10 == 0) {
            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //                str += dozens[0];

            //            else if (number / 10 % 10 == 2)
            //                str += dozens[1];

            //            else if (number / 10 % 10 == 3)
            //                str += dozens[2];

            //            else if (number / 10 % 10 == 4)
            //                str += dozens[3];

            //            else if (number / 10 % 10 == 5)
            //                str += dozens[4];

            //            else if (number / 10 % 10 == 6)
            //                str += dozens[5];

            //            else if (number / 10 % 10 == 7)
            //                str += dozens[6];

            //            else if (number / 10 % 10 == 8)
            //                str += dozens[7];

            //            else
            //                str += dozens[8];                        
            //    }

            //    else if (number / 10 % 10 == 0) {
            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }

            //    else {
            //        if (number / 100 % 10 == 1)
            //            str += hundreds[0];

            //        else if (number / 100 % 10 == 2)
            //            str += hundreds[1];

            //        else if (number / 100 % 10 == 3)
            //            str += hundreds[2];

            //        else if (number / 100 % 10 == 4)
            //            str += hundreds[3];

            //        else if (number / 100 % 10 == 5)
            //            str += hundreds[4];

            //        else if (number / 100 % 10 == 6)
            //            str += hundreds[5];

            //        else if (number / 100 % 10 == 7)
            //            str += hundreds[6];

            //        else if (number / 100 % 10 == 8)
            //            str += hundreds[7];

            //        else
            //            str += hundreds[8];

            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];

            //        if (number % 10 == 1)
            //            str += numbers[0];

            //        else if (number % 10 == 2)
            //            str += numbers[1];

            //        else if (number % 10 == 3)
            //            str += numbers[2];

            //        else if (number % 10 == 4)
            //            str += numbers[3];

            //        else if (number % 10 == 5)
            //            str += numbers[4];

            //        else if (number % 10 == 6)
            //            str += numbers[5];

            //        else if (number % 10 == 7)
            //            str += numbers[6];

            //        else if (number % 10 == 8)
            //            str += numbers[7];

            //        else
            //            str += numbers[8];
            //    }
            //}

            //else if (number >= 10 && number < 100) {
            //    if (number > 10 && number < 20) {
            //        if (number == 11)
            //            str += tentotwenty[0];

            //        else if (number == 12)
            //            str += tentotwenty[1];

            //        else if (number == 13)
            //            str += tentotwenty[2];

            //        else if (number == 14)
            //            str += tentotwenty[3];

            //        else if (number == 15)
            //            str += tentotwenty[4];

            //        else if (number == 16)
            //            str += tentotwenty[5];

            //        else if (number == 17)
            //            str += tentotwenty[6];

            //        else if (number == 18)
            //            str += tentotwenty[7];

            //        else 
            //            str += tentotwenty[8];
            //    }

            //    else {
            //    if(number % 10 == 0) {
            //        if (number / 10 % 10 == 1)
            //            str += dozens[0];

            //        else if (number / 10 % 10 == 2)
            //            str += dozens[1];

            //        else if (number / 10 % 10 == 3)
            //            str += dozens[2];

            //        else if (number / 10 % 10 == 4)
            //            str += dozens[3];

            //        else if (number / 10 % 10 == 5)
            //            str += dozens[4];

            //        else if (number / 10 % 10 == 6)
            //            str += dozens[5];

            //        else if (number / 10 % 10 == 7)
            //            str += dozens[6];

            //        else if (number / 10 % 10 == 8)
            //            str += dozens[7];

            //        else
            //            str += dozens[8];
            //    }
            //    else {
            //            if (number / 10 % 10 == 1)
            //                str += dozens[0];

            //            else if (number / 10 % 10 == 2)
            //                str += dozens[1];

            //            else if (number / 10 % 10 == 3)
            //                str += dozens[2];

            //            else if (number / 10 % 10 == 4)
            //                str += dozens[3];

            //            else if (number / 10 % 10 == 5)
            //                str += dozens[4];

            //            else if (number / 10 % 10 == 6)
            //                str += dozens[5];

            //            else if (number / 10 % 10 == 7)
            //                str += dozens[6];

            //            else if (number / 10 % 10 == 8)
            //                str += dozens[7];

            //            else
            //                str += dozens[8];

            //            if (number % 10 == 1)
            //                str += numbers[0];

            //            else if (number % 10 == 2)
            //                str += numbers[1];

            //            else if (number % 10 == 3)
            //                str += numbers[2];

            //            else if (number % 10 == 4)
            //                str += numbers[3];

            //            else if (number % 10 == 5)
            //                str += numbers[4];

            //            else if (number % 10 == 6)
            //                str += numbers[5];

            //            else if (number % 10 == 7)
            //                str += numbers[6];

            //            else if (number % 10 == 8)
            //                str += numbers[7];

            //            else
            //                str += numbers[8];
            //        }
            //    }
            //}

            //else if(number >= 1 && number < 10) {
            //    if (number == 1)
            //        str += numbers[0];

            //    else if (number == 2)
            //        str += numbers[1];

            //    else if (number == 3)
            //        str += numbers[2];

            //    else if (number == 4)
            //        str += numbers[3];

            //    else if (number == 5)
            //        str += numbers[4];

            //    else if (number == 6)
            //        str += numbers[5];

            //    else if (number == 7)
            //        str += numbers[6];

            //    else if (number == 8)
            //        str += numbers[7];

            //    else
            //        str += numbers[8];

            //}

            //Console.WriteLine(str);

            //3
            int[] ar = { 1, 11, 21, 1211, 111221, 312211, 13112221 };
            //Console.WriteLine(stri);
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < ar.Length; i++) {
                if (ar[i] == number) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
