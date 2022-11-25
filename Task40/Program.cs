// Напишите программу, которая принимает на вход три числа и проверяет, может ли существоввать 
//треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона теругольника меньше суммы двух других сторон
Console.WriteLine("Enter A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter C");
int C = Convert.ToInt32(Console.ReadLine());

// if(A < B + C && B < A + C && C < A +B)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
 
bool res = IsTriangleExist(A,B,C);
if (res  == true)
{
    Console.WriteLine("Triangle exists");
}
else
{
     Console.WriteLine("Triangle dasn't exist");
}

bool IsTriangleExist(int a, int b, int c)  //метод
{
    bool isExist = false; //такой треугольник не существует

    if(a < b + c && b < a + c && c < a +b)
    {
        isExist = true; // такой треугольник может существовать (false - по умолчанию)
    }
    return isExist;
}