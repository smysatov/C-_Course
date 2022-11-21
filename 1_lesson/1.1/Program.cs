// вход 2 числа, проверка, является ли 1ое квадратом 2го

Console.WriteLine("Enter first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int num2 = int.Parse(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("YES");
}

else
    Console.WriteLine("NO");