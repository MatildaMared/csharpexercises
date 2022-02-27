/*
Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an 
error message and ask the user to re-try. Once the 
user successfully enters 5 unique numbers, 
sort them and display the result on the console.
*/

Console.WriteLine("Please enter five unique numbers and I will sort them for you! 🥳");

var numbers = new List<int>();

while (numbers.Count < 5) {
	Console.Write("\nPlease enter a number: ");
	var input = Console.ReadLine();
	var userNumber = int.Parse(input);

	if (numbers.Contains(userNumber)) {
		Console.WriteLine("\nYou already entered that number! 😢 Please try again.");
	}
	else {
		numbers.Add(userNumber);
	}

	if (numbers.Count == 5) {
		break;
	}
}

numbers.Sort();

Console.Write("\nHere are the sorted numbers: ");

foreach (var number in numbers) {
	Console.Write(number + " ");
}

Console.WriteLine("\n\nThank you for using my program! 🤗");