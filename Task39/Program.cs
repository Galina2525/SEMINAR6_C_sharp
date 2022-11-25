// Напишите программу, которая перевернет одномерный массив(последний элемент будет на
// первом месте, а первый - на последнем
//[1,2,3,4,5,] -> [5,4,3,2,1]
//[ 6 7 3 6] -> [6 3 7 6]

const int ARRAY_SIZE = 5;
const int MIN_VALUE = -10;
const int MAX_VALUE = 10;


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

   ReverseArray(arr);
   Console.WriteLine($"NEW Massiv [{string.Join(", ", arr)}]");// выводим новый массив
   
   void ReverseArray(int[] array)
   {
     for (int i = 0; i < array.Length / 2; i++)
     {
        int temp = array [i];
        array [i] = array[array.Length - 1-i];
        array[array.Length - 1 -i] = temp;

     }
   }