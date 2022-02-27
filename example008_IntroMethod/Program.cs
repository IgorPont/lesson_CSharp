int a1 = 13;
int b1 = 34;
int c1 = 45;
int a2 = 129;
int b2 = 23;
int c2 = 888;
int a3 = 99;
int b3 = 12;
int c3 = 27;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);