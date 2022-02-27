/*
Write a program and ask the user to supply a list of 
comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, 
display "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list.
*/

Console.WriteLine("This program will return the three smallest numbers of a list of numbers. 😊");

var numbers = new List<int>();

while (true) {
	Console.Write("\nPlease enter five numbers, separated by commas: ");

	var userInput = Console.ReadLine();

	var inputArray = userInput.Split(',');

	if (inputArray.Length != 5) {
		Console.WriteLine("\nInvalid list. Please try again.");
		continue;
	}

	foreach (var number in inputArray) {
		numbers.Add(int.Parse(number));
	}

	break;
}



numbers.Sort();

Console.WriteLine($"\nThe three smallest numbers are {numbers[0]}, {numbers[1]}, and {numbers[2]}.");

Console.WriteLine("\nThank you for using my program! 🦄");