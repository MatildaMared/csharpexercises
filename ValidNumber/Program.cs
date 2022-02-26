Console.WriteLine("Can you enter a valid number? 😱");
Console.WriteLine("Please enter a number between 1 and 10:");

var userInput = Console.ReadLine();
var number = int.Parse(userInput);

if (number > 0 && number < 10) {
	Console.WriteLine("Wow! You entered a valid number, good job! 🎉");
}
else {
	Console.WriteLine("You can't read simple instructions now, can you? 🤔");
}
