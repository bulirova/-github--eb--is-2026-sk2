int number;

Console.Write("Enter an integer: ");

while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Invalid input. Try again: ");
}

string number_text = number.ToString();

int sum = 0;
int product = 1;


foreach (char character in number_text)
{
    if (character == '-')
    {
        continue;
    }

    int digit = character - '0';

    sum = sum + digit;
    product = product * digit;
}

Console.WriteLine($"Sum of digits: {sum}");
Console.WriteLine($"Product of digits: {product}");
