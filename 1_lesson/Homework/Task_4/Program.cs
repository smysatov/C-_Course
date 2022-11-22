// Программа на вход принимает число (N), а на выходе
// показывает все четные числа от 1 до N

Console.WriteLine("Enter number");
int N = int.Parse(Console.ReadLine());
int x = 1;

while (x<=N)
{
    if (x%2==0)
    Console.Write(x+", ");
    x++;
}