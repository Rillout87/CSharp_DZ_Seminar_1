//ДЗ Задача 2. На вход 2 числа, вывод какое число большее, какое меньшее
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 != number2)
{
    if (number1 > number2)
    {
        Console.WriteLine("Число " + number1 + " больше, чем число " + number2);
    }

    else Console.WriteLine("Число " + number1 + " меньше, чем число " + number2);
}

else Console.WriteLine("Числа равны");
