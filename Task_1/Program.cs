/*
Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
int i = 0;
int Sum = 0;

Console.WriteLine("Введите натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[num1];
Console.WriteLine("Введите числа: ");

while (i< num1)
{
    int num2 = Convert.ToInt32(Console.ReadLine());
    Array[i] = num2;
    if (Array[i] > 0)
            Sum = Sum + 1;
    i++;
}

Console.WriteLine("Введено чисел больше нуля: " + Sum);
