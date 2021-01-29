using System;

namespace Training_programms
{
    class Program
    {
        static void Summ(int num1, int num2)
        {
            int Sum = num1;
            while(num1 < num2 && num1 >= 0 &&num2 >= 0)
            {
                Sum += ++num1;
            }
            Console.WriteLine($"Sum is {Sum}");
        }
        static void Multiply(int num1,int num2)
        {
            int Multi = 1;
            for(int i = num1; i <= num2; i++)
            {
                Multi *= ++num1;
            }
            Console.WriteLine($"Multiply is {Multi}");
        }

        static void Table(int num1)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"{num1} * {counter} = {num1 * counter}");
                counter++;
            }
            while (counter <= 10);
        }
        static void Menu()
        {
            Console.WriteLine("1)Играть \n 2)О программе \n 3)Выход"); ;
        }
        static void WhatIsTheNumber ()
        {
            int choice;
            do
            {
                Menu();
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            int num1 = 0;
                            int num2 = 1000;
                            int counter = 0;
                            Console.WriteLine("Окей, ты модешь загадать число от 0 до 1000");
                            string answer = "no";
                            while (answer != "yes")
                            {
                                int temp = num2 - (num2 - num1) / 2;
                                Console.WriteLine($"Окей, твоё число > {temp}?");
                                counter++;
                                char answer1 = char.Parse(Console.ReadLine());
                                if (answer1 == '+')
                                {
                                    num1 = temp + 1;
                                    Console.WriteLine($"Левая граница теперь {num1}");
                                }
                                else if (answer1 == '-')
                                {
                                    Console.WriteLine($"Твоё число < {temp}?");
                                    counter++;
                                    char answer2 = char.Parse(Console.ReadLine());
                                    if (answer2 == '+')
                                    {
                                        num2 = temp - 1;
                                        Console.WriteLine($"Правая граница теперь {num2}");
                                    }
                                    else if (answer2 == '-')
                                    {
                                        Console.WriteLine($"Заганное число = {temp} \nЧтобы отгадать его, потребовалось {counter} шагов");
                                        break;
                                    }
                                }
                                Console.WriteLine($"Границы на итерации: {num1}-{num2}");


                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Данная программа угадает загаданное тобой число, диапазон чисел 0-1000. ");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Спасибо за использование нашеё программы, до свидания!)");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите что-то нормальное!)");
                            break;
                        }
                }
            }
            while (choice != 3);
            
        }

        static void Check(int num1)
        {
            int determinant = 1;
            for ( int i = determinant; i <= 7; i++)
            {
                if (num1 % i == 0 && i != num1)
                {
                    Console.WriteLine($"{num1} / {i}");

                }
                else
                {
                    Console.WriteLine("Число простое");
                }
                
            }
            Console.WriteLine($"{num1} / {num1} = 1");
        }
        static void Main(string[] args)
        {
            WhatIsTheNumber();
        }
    }
}
