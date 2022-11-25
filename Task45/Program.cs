// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования
// int [] array = {1, 2, 3, 7, 65};
// int [] NewArray = new int [array.Length];
// for (int i =0; i < array.Length; i++)
// {
//    NewArray[i] = array[i];
// }
// Console.WriteLine($"Array = {string.Join(", ", array)}");
// Console.WriteLine($"New Array = {string.Join(", ", NewArray)}");


// С ПОМОЩЬЮ МЕТОДА 

const int  ARRAY_SIZE = 5;
const int  MIN_VALUE = 2;
const int  MAX_VALUE = 100;
int [] arr = FiLLArrayWithRandomNumber(ARRAY_SIZE, MIN_VALUE, MAX_VALUE);

//int [] copyArray = arr;//так копируется только ссылка, а не сами элементы
int [] copyArray = CopyArray(arr);// так копируются элементы

arr[0] = 100; //тестируем. НО если эту строчку поставить между методами, то 100 будет в двух массивах

int [] FiLLArrayWithRandomNumber(int size, int minValue,int maxValue)
{
    int [] array = new int [size];
    Random random = new Random();
     for(int i = 0; i < size; i ++)
    {
     array [i] = random.Next(minValue, maxValue);
    }
    return array;
}
Console.WriteLine($"Array [{string.Join(", ", arr)}]");// выводим исходный массив
Console.WriteLine($"Copy Array [{string.Join(", ", copyArray)}]");// выводим исходный массив
// PrintArray(arr);
// PrintArray(copyArray);

// void PrintArray (int [] array)
// {
//     for(int i = 0; i < array.Length; i ++)
//     {
//      Console.Write($"{array[i]} ");
//     }
// }

int[] CopyArray(int[]sourseArray)
{
    int[] destinationArray = new int [sourseArray.Length];
    for(int i = 0; i < sourseArray.Length; i ++)
    {
        destinationArray[i] = sourseArray[i];
    }
     return destinationArray;
}