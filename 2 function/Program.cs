using System;

namespace _2_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentageHealthFilling;
            int maxHealth = 10;
            int healthPosition = 5;
            int percentageManaFilling;
            int maxMana = 10;
            int manaPosition = 6;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Введите процент заполнеия шкалы здоровья: ");
                percentageHealthFilling = (Convert.ToInt32(Console.ReadLine()) * maxHealth) / 100;
                Console.Write("Введите процент заполнеия шкалы маны: ");
                percentageManaFilling = (Convert.ToInt32(Console.ReadLine()) * maxMana) / 100; ;
                Console.Clear();

                DrawBar(percentageHealthFilling, maxHealth, healthPosition);
                DrawBar(percentageManaFilling, maxMana, manaPosition);

            }
        }
        static void DrawBar(int value, int maxValue, int position)
        {
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += '#';
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.Write(bar);
    
            bar = "";

            for(int i = value; i < maxValue; i++)
            {
                bar += ' ';
            }
            Console.Write(bar + ']');
        } 
    }
}
