void FillArray(int[] collection) // метод заполняет произвольными числами массив
{
   int length = collection.Length;
   int index = 0;

   while (index < length)
   {
      collection[index] = new Random().Next(1, 10);
      index++;
   }
}

void PrintArray(int[] col) // метод выводит цифры произвольно заполненного массива
{
   int count = col.Length;
   int position = 0;

   while (position < count)
   {
      Console.Write(col[position] + " ");
      position++;
   }
}

int IndexOf(int[] collection, int find) // метод поиска элемента с определенным значением
{
   int count = collection.Length;
   int index = 0;
   int position = -1; // выводит, если элемент не найден (условное обозначение, чтобы понимать, что элемент не найден)

   while (index < count)
   {
      if (collection[index] == find)
      {
         position = index;
         break; // останавливает выполенние метода после того, как нашел первое совпадение
      }
      index++;
   }
   return position;
}


int[] array = new int[10]; // определили массив из 10 чисел

FillArray(array); // запустили первый метод
PrintArray(array); // запустили второй метод
Console.WriteLine(" /"); // пустая строка, чтобы отделить последний элемент массива от найденного числа 

int pos = IndexOf(array, 4); // ищем элемен со значением "4"
Console.WriteLine(pos);