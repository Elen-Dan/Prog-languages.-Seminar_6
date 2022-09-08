/*
Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
int i = 0;
int Sum = 0;
int[] Array = new int[999]; 
Console.WriteLine("Введите пять натуральных чисел: ");

while (i< 5)
{
    int Num = Convert.ToInt32(Console.ReadLine());
    Array[i] = Num;
    if (Array[i] > 0)
            Sum = Sum + Array[i];
    i++;
}

Console.WriteLine("Введено чисел больше нуля: " + Sum);
