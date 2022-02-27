/*
Write a program to count how many numbers between 
1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.
*/

Console.WriteLine("This program will count how many numbers between 1 and 100 that are divisible by 3 with no remainder. 😙");
Console.WriteLine("Let's go! 🤩\n");

string numbersThatAreDivisibleBy3 = "";

for (var i = 0; i < 100; i++) {
	if (i % 3 == 0) {
		Console.WriteLine($"The number {i} is divisible by 3 with no remainder.");
		numbersThatAreDivisibleBy3 += i + ", ";
	}
}

Console.WriteLine($"\nThe numbers that are divisible by 3 with no remainder are: \n{numbersThatAreDivisibleBy3}");;