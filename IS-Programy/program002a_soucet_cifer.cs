Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine()!);

int sum = 0;
int multiple = 1;

while (number > 0 )
{
    int digit = number % 10;
    sum = sum + digit;
    multiple = multiple * digit;

    number = number / 10;
}

Console.WriteLine($"Sum of digits: {sum}");
Console.WriteLine($"Mutiple of digits: {multiple}");