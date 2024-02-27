string[] names = new string[] { "Tim", "Sue", "Bob" };
bool isValidNumber;
int number;

do
{
	Console.Write("Enter a number from 0 to 2: ");
	string? numberText = Console.ReadLine();

	isValidNumber = int.TryParse(numberText, out number);

	if ( number < 0 || number > 2 )
	{
		isValidNumber = false;
	}

	if ( !isValidNumber )
	{
		Console.WriteLine("That is not a valid number; please try again.");
	}
} while ( !isValidNumber );

Console.WriteLine($"The name at position {number} is {names[number]}.");
