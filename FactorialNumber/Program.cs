/*
Write a program and ask the user to enter a number. 
Compute the factorial of the number and print it 
on the console. For example, if the user enters 5, 
the program should calculate 5 x 4 x 3 x 2 x 1 
and display it as 5! = 120.
*/

Console.WriteLine("Hello! 🤗 This program calculates the factorial of a number.\n");

Console.Write("Please enter a number: ");
var number = int.Parse(Console.ReadLine());

var result = number;

// Calculate the factorial based on user input
for (var i = number - 1; i > 0; i--) {
	result *= i;
}

Console.WriteLine($"\nThe factorial of number {number} is {result}!");
Console.WriteLine("\nThank you for using this program and have a nice day! 🐰");