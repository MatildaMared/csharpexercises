/*
 * Write a program and ask the user to enter a few
 * numbers separated by a hyphen. If the user simply
 * presses Enter, without supplying an input, exit
 * immediately; otherwise, check to see if there
 * are duplicates. If so, display "Duplicate"
 * on the console.
 */

Console.WriteLine("Enter a few numbers separated by a hyphen and I will check for duplicates! ☺️");
Console.WriteLine("Press Enter without supplying an input to exit.");
Console.WriteLine("Example: 12-17-64-9-3");
Console.Write("\nEnter your numbers: ");

var userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput)) {
    Console.WriteLine("\nYou didn't enter anything! Exiting...");
    Environment.Exit(0);
}

var numbers = userInput.Split('-');

if (numbers.Length != numbers.Distinct().Count()) {
	Console.WriteLine("\nDuplicate numbers detected! ☹️");
} else {
	Console.WriteLine("\nNo duplicates detected! ☺️");
}