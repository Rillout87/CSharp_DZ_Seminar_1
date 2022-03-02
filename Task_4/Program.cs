//ДЗ Задача 4. На вход 3 числа, на выход максимальное из этих трех

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if(number1 > number3)
    {    
        Console.WriteLine("Максимально число: " + number1);
    }
    else Console.WriteLine ("Максимально число: " + number3);
}
else if (number2 > number3){
{
    Console.WriteLine("Максимально число: " + number2);}
}

    else {Console.WriteLine("Максимально число: " + number3);}

