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
AddMassString(array);
System.Console.WriteLine($"Значения из массива меньше или равны {o} символам:");
PrintResults(Results(array));


// функ. для добавления элементов массива по указанным параметрам пользователя
void AddMassString(string[] arr) 
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    System.Console.WriteLine("Введите значение массива №" + (i + 1));
    arr[i] = Console.ReadLine();
  }
}

// функ. для фильтрации элементов массива, по условию заданным пользователем
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
  string[] tempArray = new string[tempInt]; // создаем новый массив для занесения элементов по условию
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
 
//функ. по выводу результирующего массива элементов
void PrintResults(string[] arr) 
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    System.Console.Write($"{arr[i]} ");
  }
}

