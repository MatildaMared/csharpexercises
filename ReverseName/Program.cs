/*
Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store 
the result in a new string. Display the 
reversed name on the console.
*/

Console.Write("Hi! 💖 Please enter your name: ");
var name = Console.ReadLine();

var reversedName = "";

for (var i = name.Length - 1; i >= 0; i--) {
	reversedName += name[i];
}

Console.WriteLine($"\nThank you {name}! 🤗 Did you know that your name reversed is {reversedName}? 😄");