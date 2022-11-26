// Принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23!!!

Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine());

string Cratno(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "yes";
    else
        return "no";    
}
Console.WriteLine(Cratno(num));