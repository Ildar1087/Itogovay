/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

["hello", "2", "world", ":-)"] -> ["2",":-)"]
["1234","1256","-2","computer science"] -> ["-2"]

*/
System.Console.WriteLine("Введите количество массивов: ");
int k = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число ограничения длины массива: ");
int o = int.Parse(Console.ReadLine());
string[] array = new string[k];
AddString(array);
System.Console.WriteLine($"Значения из массива меньше или равны {o} символам:");
ShowResults(Results(array));



void AddString(string[] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    System.Console.WriteLine("Введите значение массива №" + (i + 1));
    arr[i] = Console.ReadLine();
  }
}

string[] Results(string[] arr)
{
  int tempInt = 0;
  int tempI = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    if (arr[i].Length <= o)
    {
      tempInt++;
    }
  }
  string[] tempArray = new string[tempInt];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    if (arr[i].Length <= o)
    {
      tempArray[tempI] = arr[i];
      tempI++;
    }
  }
  return tempArray;
}

void PrintResults(string[] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    System.Console.WriteLine(arr[i]);
  }
}

// string[] arriva = { "123; 124; aasdas; asda sd; 123; 123; 124; 124" };
// // Print(arr);
// // Print(DeleteEqualValues(arr));
// // NullMass(arriva);
// // string[] NullMass(string[] arr)
// // {
// //   string[] nulmas = new string[arr];
// //   for(int i = 0; i < arr.Length; i++)
// //   {
// // System.Console.WriteLine(nulmas);
// //   }
// //   return nulmas;
// // }
// GetArray(arriva);
// string[] s = GetArray(arriva);
// PrintArray(s);

// string[] GetArray(string[] m)
// {
//   int free = 3;
//   string[] result = new string[m.Length];
//   for (int i = 0; i < free; i++)
//   {
//     result[i] = m [i];
//   }
//   return result;
// }

// void PrintArray(string[] inArray)
// {
//   for (int i = 0; i < inArray.GetLength(0); i++)
//   {
//     Console.Write($"{inArray[i]} ");
//   }
// }


// using System;
// using System.Linq;
// int x = 3;

// Console.Write("введите значения через пробел: ");
// int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
// int[] array = new int[numbers.Length];
// for (int i = 0; i < x; i++)
// {
//   array[i] = numbers[i];
//   System.Console.WriteLine(array[i]);
// // }
// string[] d = {dfd, 34, lok, jora, oih, 9898, 9, 78};
// Console.WriteLine(d);

