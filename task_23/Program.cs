// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}
void CubeNumber (int Number)
{
    for (int N = 1; N < Number+1; N=N+1)
    {
        int Cube = N*N*N;
        if (N<Number)
        {
            Console.Write($"  {Cube}, ");
        }
        else 
        {
            Console.Write($"  {Cube}");
        }
    }
}
int N = GetUserNumber("Input number");
CubeNumber(N);
