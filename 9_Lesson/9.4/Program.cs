//Напишиет программу, которая на вход принимает два числа
//А и В, и возводит число А в целую степень В рекурсивно.

int Pow(int a, int b)
{
    if (b == 0)
        return 1;
    return Pow(a, b - 1) * a;
}

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write($"a в степени b: {Pow(a, b)}");
