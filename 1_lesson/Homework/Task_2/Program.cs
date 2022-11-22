// Принимает на вход три числа и выдает максимальное
// из этих чисел

Console.WriteLine("Enter first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third number");
int num3 = int.Parse(Console.ReadLine());

int max;

max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}


Console.Write("max = ");
Console.Write(max);