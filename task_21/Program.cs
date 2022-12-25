// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int Coodrdinates = int.Parse(Console.ReadLine()!);
    return Coodrdinates;
}
int a1 = GetUserNumber("Input a1: ");
int b1 = GetUserNumber("Input b1: ");
int c1 = GetUserNumber("Input c1: ");
int a2 = GetUserNumber("Input a2: ");
int b2 = GetUserNumber("Input b2: ");
int c2 = GetUserNumber("Input c2: ");

double sqrt = Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
Console.WriteLine($" the length is {sqrt}");