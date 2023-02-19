Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 0;
while(i < n)
{
    i++;
    Console.Write(" " + i*i*i);
}