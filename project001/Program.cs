int a1 = 12;
int b1 = 48;
int c1 = 65;
int a2 = 87;
int b2 = 95;
int c2 = 100;
int a3 = 31;
int b3 = 45;
int c3 = 54;

int max = a1;

if (b1 > max) max = b1; if (c1 > max) max = c1; if (a2 > max) max = a2;
if (b2 > max) max = b2; if (c2 > max) max = c2; if (a3 > max) max = a3;
if (b3 > max) max = b3; if ( c3 > max) max = c3;
Console.WriteLine(max);
