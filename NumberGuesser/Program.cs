/*
Write a program that picks a random number between 1 and 10. 
Give the user 4 chances to guess the number. If the user 
guesses the number, display “You won"; otherwise, display 
“You lost". (To make sure the program is behaving correctly, 
you can display the secret number on the console first.)
*/

Console.WriteLine("Hello 👋 I've chosen a random number between 1 and 10 and it's up to you to guess it! 😄");

var random = new Random();
var randomNumber = random.Next(1, 11);

int userGuess;

for (var guessesLeft = 4; guessesLeft > 0; guessesLeft--) {
	Console.WriteLine($"\nYou have {guessesLeft} guesses left..\n");
	Console.Write("Guess a number between 1 and 10: ");
	
	userGuess = Convert.ToInt32(Console.ReadLine());

	if (userGuess == randomNumber) {
		Console.WriteLine($"\nWow, you won! 🎉 The number was {randomNumber}. Good job! 😄");
		break;
	} else if (guessesLeft == 1) {
		Console.WriteLine($"\nYou lost! 😭 The number was {randomNumber}.");
	} else {
		Console.WriteLine($"\nNope, try again! 😢");
	}
}

Console.WriteLine("\nThank you for playing this game with me! 🤗");