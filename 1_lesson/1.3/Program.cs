// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Enter a number:");
string a = Console.ReadLine();
int N = int.Parse(a);
int negN = -N;
while (negN <= N)
{
    Console.Write($"{negN} ");
    negN +=1;
}