int a1 = 6;
int b1 = 8;
int c1 = 4;
int a2 = 2;
int b2 = 10;
int c2 = 9;
int a3 = 98;
int b3 = 5;
int c3 = 6;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);