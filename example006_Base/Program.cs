int a = 37;
int b = 7;
int c = 10;
int d = 32;
int e = 1;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число равно ");
Console.WriteLine(max);