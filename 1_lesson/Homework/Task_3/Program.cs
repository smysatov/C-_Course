// Программа на вход принимает число и выдает, является ли
// число четным (делится ли оно на 2 без остатка)

Console.WriteLine("Enter number");

int num = int.Parse(Console.ReadLine());
    
if (num % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}