//ДЗ Задача 6. На вход число, на выход - является ли оно четным
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Число " + number + " четное");
else Console.WriteLine("Число " + number + " нечетное");