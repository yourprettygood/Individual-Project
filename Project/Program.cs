using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            Console.ForegroundColor =ConsoleColor.Green;
            Console.Title = "Дидур Даниил, Индивидуальный проект на тему: Алгоритм Евклида ";

            Console.Write("Введите 1-ое число: ");//Запрашиваем у пользователя 1-ое  число
            int a = int.Parse(Console.ReadLine());//Объявление переменной, которая будет хранить 1-ое число пользователя
            Console.Write("Введите 2-ое число: ");//Запрашиваем у пользователя 2-ое  число
            int b = int.Parse(Console.ReadLine());//Объявление переменной, которая будет хранить 2-ое число пользователя                     
                while (a != b) //Создаем цикл while, с условием, что 1-ое число будет меньше 2-ого
                {
                    if (a > b)//В этом цикле проверяем, если 1-ое число больше 2-ого.
                    {
                        a = a - b;//Операция, которая будет выполняться при выполнения условия
                    }
                    else
                    {
                        b = b - a;//Операция, которая будет выполняться при невыполнении условия выше
                    }
                }
            Console.WriteLine($"Нод = {b} ");//Выводим в консоль значение НОД'а


            Console.ReadLine();
        }
    }
}
