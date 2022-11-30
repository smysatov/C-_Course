// Программа принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double result;
    result = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
    return result;
}
int Ax = ReadNumber("Enter the coordinates Ax: ");
int Ay = ReadNumber("Enter the coordinates Ay: ");
int Az = ReadNumber("Enter the coordinates Az: ");

int Bx = ReadNumber("Enter the coordinates Bx: ");
int By = ReadNumber("Enter the coordinates By: ");
int Bz = ReadNumber("Enter the coordinates Bz: ");

Console.WriteLine($"Distance beetwin A and B -> {Math.Round(Distance(Ax, Ay, Az, Bx, By, Bz), 2)}");
