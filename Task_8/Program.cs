//ДЗ Задача 8. На вход число N, на выход все четные числа от 1 до N

Console.Write("Введите число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if(i % 2 == 0) Console.Write(i + ",");
}
