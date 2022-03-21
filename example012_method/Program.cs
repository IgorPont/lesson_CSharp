// 1 вид методов (ничего не принимает и ничего не возвращает)
/*
void Method1()
{
   Console.WriteLine("Автор...");
}

Method1(); // вызываем метод

// 2 вид методов (что-то принимает, но ничего не возвращает)

void Method2(string msg, int count)
{
   for (int i = 0; i < count; i++) Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения", count: 4);

// 3 вид методов (ничего не принимает, но возвращает какой-о аргумент)

int Method3()
{
   return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 4 вид методов (что-то принимают и что-то возвращают)

string Method4(int count, string text)
{
   string result = String.Empty;
   for (int i = 0; i < count; i++)
   {
      result = result + text;
   }
   return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// Задача. Вывести таблицу умножения на экран

for (int i = 2; i <= 9; i++)
{
   for (int j = 2; j <= 9; j++)
   {
      Console.WriteLine($"{i} x {j} = {i * j}");
   }
   Console.WriteLine();
}


// ==== Задача. Работа с текстом.
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить ольшими буквами "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] - четвертый сомвол в строке, то есть "r" 

string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty;

   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
      if (text[i] == oldValue) result = result + $"{newValue}";
      else result = result + $"{text[i]}";
   }
   return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();

*/

// ==== Задача. Упорядочить массив (метод выбора минимального).

void RandomArray(int[] array) // метод заполнения массива рандомными числами
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      array[i] = new Random().Next(1, 100);
   }
}

void PrintArray(int[] array) // метод вывода массива на в консоле
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

void SelectionSort(int[] array) // метод подмены наименьшим числом
{
   for (int i = 0; i < array.Length - 1; i++)
   {
      int minPosition = i;

      for (int j = i + 1; j < array.Length; j++)
      {
         if (array[j] < array[minPosition]) minPosition = j;
      }

      int temporary = array[i];
      array[i] = array[minPosition];
      array[minPosition] = temporary;
   }
}

int[] arr = new int[10];

RandomArray(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
