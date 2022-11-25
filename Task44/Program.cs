// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
//Если N = 5 => 0 1 1 2 3
//Если N = 3 => 0 1 1 
//Если N = 7 => 0 1 1 2 3 5 8

Console.WriteLine("Enter number  ");
int number = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [number];


// for(int i = 2; i < array.Length; i ++)
// {
   
//    array[1] = 1;
//    array[i] = array[i-1] + array [i-2];
// }

// Console.WriteLine($" {string.Join(", ", array)}");

void Fibonachy (int [] arr) //метод поиска чисел Фибоначи
{
   int number = arr.Length;
   for(int i = 2; i < arr.Length; i ++)
{
   
   arr[1] = 1;
   arr[i] = arr[i-1] + arr [i-2];
}
}

void PrintArray(int[]arr) // метод вывода массива на печать
{    
    for(int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int[]array = new int [number];
Fibonachy(array);
PrintArray(array);
// Другой метод

// PrintFibonachyToNumber(number);// вызов метода
 
// void PrintFibonachyToNumber(int N)

// {
//     Console.WriteLine("0 1");
//     int neibour1 = 0;
//     int neibour2 = 1;
//     for(int i =0; i < N - 1; i++)
//     {
//        int res = neibour1 + neibour2;
//        Console.WriteLine(res + " ");
//        neibour1 = neibour2;
//        neibour2 = res;

//     }
// }