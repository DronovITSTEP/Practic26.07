using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic26._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Пользователь вводит с клавиатуры три числа.
            Необходимо подсчитать сколько раз последовательность
            из этих
                трёх чисел встречается в массиве.
                Например:
                пользователь ввёл: 7 6 5;
                массив: 7 6 5 3 4 7 6 5 8 7 6 5;
                количество повторений последовательности: 3.
             */

            /*int[] numbers = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            string[] strArr = Console.ReadLine().Split(' ');

            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }

            int count = 0;
            for (int i = 0; i <= numbers.Length - intArr.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < intArr.Length; j++)
                {
                    if (numbers[i + j] != intArr[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    count++;
                }

            }
            Console.WriteLine(count);*/

            /*int[] n = { 5, 2, 5, 2 };

            foreach (int i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine('\n');
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }*/

            /*
             Даны 2 массива размерности M и N соответственно.
            Необходимо переписать в третий массив общие 
            элементы первых двух массивов без повторений.
             */
            /*int[] arrN = { 6, 2, 6, 8, 7 };
            int[] arrM = { 5, 7, 2, 3, 2, 1, 6 };
            int[] resArr = new int[Math.Min(arrM.Length, arrN.Length)];

            int index = 0;
            foreach (int i in arrM)
            {
                if (Array.IndexOf(arrN, i) != -1
                    && Array.IndexOf(resArr, i) == -1)
                {
                    resArr[index] = i;
                    index++;
                }
            }

            Array.Resize(ref resArr, index);

            foreach (int i in resArr)
                Console.Write(i + " ");*/


            /*
             Разработайте приложение, которое будет 
            находить минимальное и максимальное 
            значение в двумерном массиве. 
            */
            /*int[,] numbers =
            {
                {
                    4,6,2,5,3
                },
                {
                    7,2,7,4,3
                }
            };
            int maxElem = numbers[0,0];
            int minElem = numbers[0,0];
            foreach (int i in numbers)
            {
                if (i > maxElem)
                    maxElem = i;
                if (i < minElem)
                    minElem = i;
            }
            Console.WriteLine(minElem);
            Console.WriteLine(maxElem);*/

            /*
             Пользователь вводит предложение с клавиатуры. Вам
            необходимо подсчитать количество слов в нём.
             */

            /*string[] str = Console.ReadLine()
                .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(str.Length);*/

            /*
             Пользователь вводит предложение с клавиатуры. Вам
            необходимо перевернуть каждое слово предложения и
            отобразить результат на экран.
            Например:
            пользователь ввёл: sun cat dogs cup tea;
            после переворота: nus tac sgod puc aet.
             */
            /*string str = "sun cat dogs cup tea";
            string[] arrStr = str.Split(' ');

            foreach (string s in arrStr)
            {
                char[] cArr = s.ToCharArray();
                Array.Reverse(cArr);
                Console.Write(new string(cArr) + " ");
            }*/

            /*
             Пользователь вводит с клавиатуры предложение. 
            Приложение должно посчитать количество гласных букв в нём
             */
            /*string userString = Console.ReadLine();
            string vowels = "уеыаоэяию";

            int count = 0;
            foreach (char c in userString)
            {
                if (vowels.Contains(char.ToLower(c)))
                    count++;
            }
            Console.WriteLine(count);*/

            /*
             Реализуйте приложение для подсчёта количество
            вхождений подстроки в строку. Пользователь 
            вводит исходную
            строку и слово для поиска. Приложений отображает 
            результат поиска.
            Например:
            пользователь ввёл: Why she had to go. I don't know, she
            wouldn't say;
            подстрока для поиска: she;
            результат поиска: 2.
             */

            string str = "Why she had to go. I don't know, she wouldn't say";
            string subStr = "she";

            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(subStr, index)) != -1)
            {
                count++;
                index += subStr.Length;
            }
            Console.WriteLine(count);

        }
    }
}
