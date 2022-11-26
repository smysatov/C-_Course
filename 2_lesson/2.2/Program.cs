// На вход принимает 2 числа и выводит, является ли второе
// число кратным первому. Если число 2 не кратно первому,
// то программа выводит остаток от деления.

Console.WriteLine("Write first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number: ");
int num2 = int.Parse(Console.ReadLine());

string Cratno(int num1, int num2)
{
    if (num1 % num2 == 0)
        return "multiple";
    else
        return $"non-multiple, modulo {num1%num2}";
}
Console.WriteLine(Cratno(num1,num2));