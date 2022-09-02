// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

Console.WriteLine("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumElements(int a, int b)
{
    if (a == b) return a;
    else if (a < b) return a + SumElements(a + 1, b);
    else return a + SumElements(a - 1, b);
}
int sumElements = SumElements(m, n);
Console.WriteLine($"Сумма цифр = {sumElements}");


