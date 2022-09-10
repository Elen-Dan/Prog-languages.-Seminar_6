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
i = 0;
while (i < (Array.Length-i-1))
{
    Sum = Sum + Array[i] * (Array.Length-i-1);
    i++;
}
Console.WriteLine(" ");
Console.WriteLine("Сумма произведений пар чисел массива: " + Sum);
