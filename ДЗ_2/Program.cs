Console.Clear();

Console.Write("Введите значение: a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение: b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение: c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if 
    (a > b)
    max = a;
else 
    max = b;

if 
    (b > c)
    max = b;
else 
    max = c;

Console.Write(max);