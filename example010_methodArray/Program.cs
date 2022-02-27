int[] array = { 2, 13, 45, 67, 95, 23, 54, 45, 90 };

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
   if (array[index] == find)
   {
      Console.WriteLine(index);
      break;
   }
   index++;
}