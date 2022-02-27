int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if (arg2 > result) result = arg2;
   if (arg3 > result) result = arg3;
   return result;
}

int a1 = 12345;
int b1 = 34;
int c1 = 45;
int a2 = 129;
int b2 = 23;
int c2 = 888;
int a3 = 99;
int b3 = 12;
int c3 = 27;
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/
int max = Max(
   Max(a1, b1, c1),
   Max(a2, b2, c2),
   Max(a3, b3, c3)); // в самой функции можно передать функцию

Console.WriteLine(max);