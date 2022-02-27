/*
Write a program and ask the user to enter a series 
of numbers separated by comma. Find the maximum of 
the numbers and display it on the console. For example, 
if the user enters “5, 3, 8, 1, 4", the program 
should display 8.
*/

Console.WriteLine("This program will determine the maximum number in a series of numbers. ☺️");
Console.Write("\nPlease enter a series of numbers separated by a comma: ");
string userInput = Console.ReadLine();

int[] numbers = userInput.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

int maxNumber = numbers.Max();

Console.WriteLine("\nThank you! 🙏 You entered the following numbers: " + userInput);

Console.WriteLine($"\nThe maximum number is: {maxNumber}");

Console.WriteLine("\nThank you for using this program! 🤗");