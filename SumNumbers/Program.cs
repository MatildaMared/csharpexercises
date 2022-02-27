/*
Write a program and ask the user to enter a number. 
Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program should 
calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
*/

Console.WriteLine("Hello! 👋 This program sums together all numbers that you enter into the console. Insert the numbers you would like to add together, and then write 'ok' to stop and display the result.");

int sum = 0;

while (true) {
	Console.Write("\nPlease enter a number or write 'ok' to stop: ");
	var input = Console.ReadLine();
	
	if (input == "ok") {
		break;
	}

	sum += int.Parse(input);
}

Console.WriteLine("\nThe sum of all the numbers you entered is: " + sum);
Console.WriteLine("\nThank you for using this program, have a nice day! 😊");