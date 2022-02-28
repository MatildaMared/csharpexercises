/*
 * Write a program and ask the user to enter an English word.
 * Count the number of vowels (a, e, o, u, i) in the word.
 * So, if the user enters "inadequate", the program
 * should display 6 on the console.
*/

char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

Console.WriteLine("Enter a word and I will count the number of vowels! 😊");
Console.Write("\nYour word: ");

var userInput = Console.ReadLine();

var vowelCount = 0;

var characters = userInput.ToCharArray();

foreach (var character in characters) {
    if (Array.IndexOf(vowels, character) > -1) {
        vowelCount++;
    }
}

Console.WriteLine("\nThere are {0} vowels in your word!", vowelCount);