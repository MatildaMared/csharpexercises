Console.WriteLine("Hello dear. This program is used to determine whether an image is in landscape or portrait mode. 🌆");
Console.WriteLine("\nPlease begin by entering the width of the image to analyze, in pixels:");

int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAnd please enter the height of the same image, also in pixels:");

int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAll set! Let's analyze... 🤗");

if (width > height) {
	Console.WriteLine("\nYour image is in landscape mode. 🌄");
}
else {
	Console.WriteLine("\nYour image is in portrait mode. 🌃");;
}

Console.WriteLine("\nThank you for using the program, and have a nice day! 😺");