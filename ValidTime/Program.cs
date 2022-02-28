/*
 * Write a program and ask the user to enter
 * a time value in the 24-hour time format (e.g. 19:00).
 * A valid time should be between 00:00 and 23:59.
 * If the time is valid, display "Ok"; otherwise,
 * display "Invalid Time". If the user doesn't
 * provide any values, consider it as invalid time.
*/

Console.Write("Please enter a time in the 24-hour format (e.g. 19:00): ");
var time = Console.ReadLine();

// Check if the time is valid
var timeArray = time.Split(':');

if (timeArray.Length == 2) {
	var hour = int.Parse(timeArray[0]);
	var minute = int.Parse(timeArray[1]);

	if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59) {
		Console.WriteLine("\nYou entered a valid time! 😄");
	}
	else {
		Console.WriteLine("\nInvalid Time... 😢");
	}
} else {
	Console.WriteLine("\nInvalid Time... 😢");
}
