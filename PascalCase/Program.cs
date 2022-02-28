/*
 * Write a program and ask the user to enter a few
 * words separated by a space. Use the words to create
 * a variable name with PascalCase. For example,
 * if the user types: "number of students", display
 * "NumberOfStudents". Make sure that the program is
 * not dependent on the input. So, if the user types
 * "NUMBER OF STUDENTS", the program should still
 * display "NumberOfStudents".
*/

Console.WriteLine("Enter a few words separated by space and I will convert them to PascalCase for you! 😀");
Console.Write("\nEnter your words: ");

var userInput = Console.ReadLine();

var words = userInput.Split(' ');

var pascalString = "";

foreach (var word in words) {
 if (pascalString.Length == 0) {
  pascalString += word.ToLower();
 }
 else {
  pascalString += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
 }
}

Console.WriteLine("\nYour words converted to PascalCase string is: " + pascalString);

Console.WriteLine("\nThank you and have a nice day! 😀");