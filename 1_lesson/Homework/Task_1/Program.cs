// На вход принимает 2 числа и выдает, какое число большее,
// а какое меньшее.

Console.WriteLine("Enter first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int num2 = int.Parse(Console.ReadLine());

if(num1 < num2)
{
    Console.Write("max = ");
    Console.Write(num2);
}

else if (num1 > num2)
{
    Console.Write("max = ");
    Console.Write(num1);
}

else
{
    Console.Write("Numbers are equal");
}