// Напишите программу, которая принимает на вход три числа и проверяет, может ли существоввать 
//треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона теругольника меньше суммы двух других сторон

const int ARRAY_SIZE = 3;
const int MIN_VALUE = 3;
const int MAX_VALUE = 17;


int [] arr = FillArrayWithRandomNumbers(ARRAY_SIZE, MIN_VALUE, MAX_VALUE);

// Метод возврвщает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int minValue, int maxValue) 
{
   int[] array = new int[size];
   Random random = new Random();
   for(int i =0; i < size; i ++)
   {
      array [i] = random.Next(minValue, maxValue + 1);
   } 
   return array;
   }
   Console.WriteLine($"Massiv [{string.Join(", ", arr)}]");// выводим исходный массив
   
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr [0]< arr[1] +arr[2] & arr[1] < arr[0]+arr[2] & arr[2] < arr[0] + arr[1] )
        {
             Console.WriteLine(" Yes");
        }
        else
        {
             Console.WriteLine(" No");

        }
    }


