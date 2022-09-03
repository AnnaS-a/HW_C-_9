// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Введите целое положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double Ackermann(double a, double b)
{
    if (a == 0) return b + 1;
    else if ((a > 0) && (b == 0)) return Ackermann(a - 1, 1);
    else if ((a > 0) && (b > 0)) return Ackermann(a - 1, Ackermann(a, b - 1));
    else return b + 1;
}

if (m <= 4 && n == 0)
{
    double res = Ackermann(m, n);
    Console.Write($"A(m,n) = {res}");
}
else if (m <= 3 && n <= 10)
{
    double res = Ackermann(m, n);
    Console.Write($"A(m,n) = {res}");
}
else
{
    Console.WriteLine("Невозможно сделать вычисления");
}


