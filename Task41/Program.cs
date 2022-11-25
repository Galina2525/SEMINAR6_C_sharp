// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше нуля
//ввел пользователь
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223 -> 3

Console.WriteLine("Ener numbers of digits");
int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
// разделяем массив строки на отдельные символы
//  берем массив строк , обращаемся к каждому
// элементу строки с помощью Select, к нему приминяем метод конвертации в int - int.Parse - 
// и приводим все к массиву (метод ToArray)
Console.WriteLine(string.Join(",", numbers));

// for(int i = 0; i < numbers.Length; i ++)
// { 
//     int count = 0;
    
//     if( numbers[i] > 0)
//     {
//        count++; 
//     }

// }
//   Console.WriteLine(count);
  




