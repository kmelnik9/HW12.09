//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается при введении слова "stop"
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void NumberPositive()
{
    Console.WriteLine("Введите число: ");
    string input = Console.ReadLine();
    int i = 0;
    while (input != "stop")
    {
        int Number = Convert.ToInt32(input);
        if (Number>0)
        {
            i++;
        }    
        Console.WriteLine("Введите число: ");  
        input = Console.ReadLine();
    }
    System.Console.WriteLine($"Количество положительных числе: {i}");
}

NumberPositive();


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection (double b1, double k1, double b2, double k2)
{
    double X = 0;
    double Y = 0;
    if (k1==k2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
        X=(b2-b1)/(k1-k2);
        Y=k1*X+b1;
        System.Console.WriteLine($"X={X}, Y={Y}");
    }
}

Intersection (2, 5, 4, 9);