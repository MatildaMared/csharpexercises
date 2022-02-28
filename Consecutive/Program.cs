/*
 * Write a program and ask the user to enter a few
 * numbers separated by a hyphen. Work out if
 * the numbers are consecutive. For example,
 * if the input is "5-6-7-8-9" or "20-19-18-17-16",
 * display a message: "Consecutive";
 * otherwise, display "Not Consecutive".
 */

Console.WriteLine("Enter a few numbers separated by hyphen, and I will figure out if they are consecutive or not! 😄");
Console.WriteLine("\nExample: 5-6-7-8-9 or 20-19-18-17-16");
Console.Write("\nEnter your numbers: ");

var numbersInput = Console.ReadLine();

var numbers = numbersInput.Split('-').Select((n) => Convert.ToInt32(n)).ToArray();

var isConsecutive = true;

for (var i = 0; i < numbers.Length - 1; i++) {
 if(numbers[i] < numbers[i + 1]) {
  continue;
 } else {
  isConsecutive = false;
  break;
 }
}

if (isConsecutive) {
 Console.WriteLine("\nYou entered consecutive numbers! 🥳");
}
else {
 Console.WriteLine("\nThese numbers are non-consecutive! 😢");
}