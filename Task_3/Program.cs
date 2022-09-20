/*
Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/
Console.Clear();
Console.WriteLine("Введите целое число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Num];
int i = 0;
while (i < Num)
{
    Array[i] = new Random().Next(1, Num);
    i++;
}

int Sum = 0;
int j = 0;
while (j < (Array.Length-j-1))
{
    Sum = Sum + Array[j] * Array[Array.Length-j-1];
    j++;
}
Console.WriteLine(" ");
Console.WriteLine("Сумма произведений пар чисел массива: " + Sum);
