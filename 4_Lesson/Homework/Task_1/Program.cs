//принимает на вход 2 числа (А и В) и возводит число А
//в натуральную степень В

Console.Write("Введите число А, ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B, ");
int B = int.Parse(Console.ReadLine());

int Stepen(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.WriteLine($"А в степени В равно: {Stepen(A, B)}");
