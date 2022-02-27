/*
Write a program and ask the user to continuously 
enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. 
Display the unique numbers that the user has entered.
*/

Console.WriteLine("Enter a series of numbers and I will sort out the unique values for you! 😄");

var numbers = new List<int>();

while (true) {
	Console.Write("\nEnter a number or type 'Quit' to exit: ");
	
	var input = Console.ReadLine();

	if (input == "Quit") {
		break;
	}
	
	numbers.Add(int.Parse(input));
}

var filteredNumbers = numbers.Distinct();

Console.Write("\nHere are the unique numbers you entered: ");

foreach (var number in filteredNumbers) {
	Console.Write(number + " ");
}

Console.WriteLine("\n\nThank you for using my program! 😄");