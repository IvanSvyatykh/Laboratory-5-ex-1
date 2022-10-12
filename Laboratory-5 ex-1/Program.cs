using System;

namespace Laboratory
{
    public static class Programm
    {
        static int numberInt;
        static float numberDouble;
        static double lastNumber;
        public static char ConvertNumberToChar()//Функция ищет в системе кодировки символ с номером как у числа
        {
            Console.WriteLine("Put your positive number to the Programm :");
            string str;
            str = Console.ReadLine();
            str = str.Trim(' ');
            if (int.TryParse(str, out numberInt))//Проверяет целое число или нет
            {
                if (numberInt >= 0) Console.WriteLine(Convert.ToChar(numberInt));
                else Console.WriteLine("You put negative number");
            }
            else//Сравнивает число с предыдущим
            {
                numberDouble = float.Parse(str);
                if (numberDouble == lastNumber) return 'q';
            }
            return 'y';
        }
        public static void Main()
        {
            char programmStopper = 'y';
            while (programmStopper != 'q')
            {
                /* Цикл работает пока текущее число не равно предыдущиму
                или пользователь хочет прекратить программу*/
                programmStopper = ConvertNumberToChar();
                if (programmStopper == 'q') break;
                Console.WriteLine("If you want stop programm put 'q', else press any button :");
                string command = Console.ReadLine();
                programmStopper = command[0];//Берем только первый символ чтобы избежать ошибки ввода строки
                Console.Clear();
                lastNumber = Math.Max(numberDouble, numberInt);/* Можем сравнивать так число
                которое не использовалось обнулится */
            }
        }
    }
}