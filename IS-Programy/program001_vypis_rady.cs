Console.Write("Please enter the first integer: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Pleae enter the last integer: ");
int last = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the 'step: ");
int step = int.Parse(Console.ReadLine()!);

if (step <= 0)
{
    Console.WriteLine("The step must be a positive integer.");
}
else
{
    for (int i = first; i <= last; i += step)
    {
        Console.WriteLine(i);
    }
}