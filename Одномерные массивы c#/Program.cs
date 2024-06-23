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
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            string[] roman1 = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] roman10 = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] roman100 = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] roman1000 = { "", "M", "MM", "MMM", "MMMM" };
            string[] symbol = new string[7000];
            int index = 0;
            for (int i = 0; i < roman1.Length; i++)
            {
                symbol[index] = roman1[i];
                index++;
            }

            for (int i = 0; i < roman10.Length; i++)
            {
                for (int j = 0; j < roman1.Length; j++)
                {
                    index++;
                    symbol[index] = roman10[i] + roman1[j];

                }
            }

            for (int k = 0; k < roman100.Length; k++)
            {
                for (int i = 0; i < roman10.Length; i++)
                {
                    for (int j = 0; j < roman1.Length; j++)
                    {
                        index++;
                        symbol[index] = roman100[k] + roman10[i] + roman1[j];

                    }
                }
            }

            for (int t = 0; t < roman1000.Length; t++)
            {
                for (int k = 0; k < roman100.Length; k++)
                {
                    for (int i = 0; i < roman10.Length; i++)
                    {
                        for (int j = 0; j < roman1.Length; j++)
                        {
                            index++;
                            if (roman1000[t] == roman1000[roman1000.Length - 1])
                            {
                                symbol[index] = roman1000[roman1000.Length - 1];
                                break;
                            }

                            symbol[index] = roman1000[t] + roman100[k] + roman10[i] + roman1[j];

                        }
                        if (roman1000[t] == roman1000[roman1000.Length - 1])
                        {
                            symbol[index] = roman1000[roman1000.Length - 1];
                            break;
                        }
                    }
                    if (roman1000[t] == roman1000[roman1000.Length - 1])
                    {
                        symbol[index] = roman1000[roman1000.Length - 1];
                        break;
                    }
                }
                if (roman1000[t] == roman1000[roman1000.Length - 1])
                {
                    symbol[index] = roman1000[roman1000.Length - 1];
                    break;
                }
            }
            foreach (var current in symbol)
            {
                Console.Write(current + " ");
            }

            //2
            string[] numbers = { "один ", "два ", "три ", "четыре ", "пять ", "шесть ", "семь ", "восемь ", "девять " };
            string[] tentotwenty = { "одинадцать ", "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ", "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать " };
            string[] dozens = { "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
            string[] hundreds = { "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
            string[] thousands = { "тысячя ", "две тысячи ", "три тысячи ", "четыре тысячи ", "пять тысяч ", "шесть тысяч ", "семь тысяч ", "восемь тысяч ", "девять тысяч " };
            string[] tenthousands = { "десять тысяч ", "двадцать тысяч ", "тридцать тысяч ", "сорок тысяч " };

            uint answer = Convert.ToUInt32(Console.ReadLine());        
            string number = "";
            string dozen = "";
            string hundred = "";
            string tenthousand = "";
            string thousand = "";

           
            if (answer / 10000 != 0)
            {
                if(answer / 10000 == 1) {
                    tenthousand = tenthousands[0];
                }

                else if (answer / 10000 == 2) {
                    tenthousand = tenthousands[1];
                }

                else if (answer / 10000 == 3) {
                    tenthousand = tenthousands[2];
                }

                else {
                    tenthousand = tenthousands[3];
                }

            }

            if (answer / 1000 != 0)
            {
                if (answer / 1000 == 1) {
                    thousand = thousands[0];
                }

                else if (answer / 1000 == 2) {
                    thousand = thousands[1];
                }

                else if (answer / 1000 == 3) {
                    thousand = thousands[2];
                }

                else if(answer / 1000 == 4) {
                    thousand = thousands[3];

                }

                else if (answer / 1000 == 5) {
                    thousand = thousands[4];
                }

                else if (answer / 1000 == 6) {
                    thousand = thousands[5];
                }

                else if (answer / 1000 == 7) {
                    thousand = thousands[6];
                }

                else if (answer / 1000 == 8) {
                    thousand = thousands[7];
                }

                else
                {
                    thousand = thousands[8];
                }

            }

            if (answer / 100 != 0)
            {
                if (answer / 100 % 10 == 1) {
                    hundred = hundreds[0];
                }

                else if (answer / 100 % 10 == 2) {
                    hundred = hundreds[1];
                }

                else if (answer / 100 % 10 == 3) {
                    hundred = hundreds[2];
                }

                else if (answer / 100 % 10 == 4) {
                    hundred = hundreds[3];

                }

                else if (answer / 100 % 10 == 5) {
                    hundred = hundreds[4];
                }

                else if (answer / 100 % 10 == 6) {
                    hundred = hundreds[5];
                }

                else if (answer / 100 % 10 == 7) {
                    hundred = hundreds[6];
                }

                else if (answer / 100 % 10 == 8) {
                    hundred = hundreds[7];
                }

                else {
                    hundred = hundreds[8];
                }   

            }

            if(answer > 10 && answer < 20) {
                if (answer == 11)
                {
                    dozen = tentotwenty[0];
                }

                else if (answer == 12)
                {
                    dozen = tentotwenty[1];
                }

                else if (answer == 13)
                {
                    dozen = tentotwenty[2];
                }

                else if (answer == 14)
                {
                    dozen = tentotwenty[3];
                }

                else if (answer == 15)
                {
                    dozen = tentotwenty[4];
                }

                else if (answer == 16)
                {
                    dozen = tentotwenty[5];
                }

                else if (answer == 17)
                {
                    dozen = tentotwenty[6];
                }

                else if (answer == 18)
                {
                    dozen = tentotwenty[7];
                }

                else
                {
                    dozen = tentotwenty[8];
                }

            }

            else {
                if (answer / 10 != 0)
                {
                    if (answer / 10 % 10 == 1)
                    {
                        dozen = dozens[0];
                    }

                    else if (answer / 10 % 10 == 2)
                    {
                        dozen = dozens[1];
                    }

                    else if (answer / 10 % 10 == 3)
                    {
                        dozen = dozens[2];
                    }

                    else if (answer / 10 % 10 == 4)
                    {
                        dozen = dozens[3];
                    }

                    else if (answer / 10 % 10 == 5)
                    {
                        dozen = dozens[4];
                    }

                    else if (answer / 10 % 10 == 6)
                    {
                        dozen = dozens[5];
                    }

                    else if (answer / 10 % 10 == 7)
                    {
                        dozen = dozens[6];
                    }

                    else if (answer / 10 % 10 == 8)
                    {
                        dozen = dozens[7];
                    }

                    else
                    {
                        dozen = dozens[8];
                    }

                }

                if (answer % 10 != 0)
                {
                    if (answer % 10 == 1)
                    {
                        number = numbers[0];
                    }

                    else if (answer % 10 == 2)
                    {
                        number = numbers[1];
                    }

                    else if (answer % 10 == 3)
                    {
                        number = numbers[2];
                    }

                    else if (answer % 10 == 4)
                    {
                        number = numbers[3];
                    }

                    else if (answer % 10 == 5)
                    {
                        number = numbers[4];
                    }

                    else if (answer % 10 == 6)
                    {
                        number = numbers[5];
                    }

                    else if (answer % 10 == 7)
                    {
                        number = numbers[6];
                    }

                    else if (answer % 10 == 8)
                    {
                        number = numbers[7];
                    }

                    else
                    {
                        number = numbers[8];
                    }

                }

            }

            Console.WriteLine(tenthousand + thousand + hundred + dozen + number);

            //3
            int[] ar = { 1, 11, 21, 1211, 111221, 312211, 13112221 };
            //Console.WriteLine(stri);
            int numb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == numb)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
    

