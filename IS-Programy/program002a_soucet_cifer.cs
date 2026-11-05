int number;

Console.Write("Enter an integer: ");

while (!int.TryParse(Console.ReadLine(), out number) )
{
    Console.Write("Invalid input. Try again: ");
}

int sum = 0;
int multiple = 1;

if (number < 0 )
{
    number = number * -1;
}

if (number == 0)
{
    multiple = 0;
}

while (number > 0 )
{
    int digit = number % 10;
    sum = sum + digit;
    multiple = multiple * digit;

    number = number / 10;
}

Console.WriteLine($"Sum of digits: {sum}");
Console.WriteLine($"Mutiple of digits: {multiple}");