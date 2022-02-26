Console.WriteLine("This is a speeding camera (not a computer terminal at all)... 😙");
Console.WriteLine("\nWhat is the current speed limit?");

var speedLimit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nThank you. Now, what is the current speed of the vehicle?");

var currentSpeed = Convert.ToInt32(Console.ReadLine());

if (currentSpeed < speedLimit) {
	Console.WriteLine("\nYou are driving at a safe speed. Good job! ☺️");
}
else {
	var demeritPoints = (currentSpeed - speedLimit) / 5;

	if (demeritPoints >= 12) {
		Console.WriteLine("\nYou have been banned from the highway. 😭");
	}
	else {
		Console.WriteLine("\nYou have " + demeritPoints + " demerit points. Please drive at a safe speed for yours and others safety! 😢");
	}
}