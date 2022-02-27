/*
When you post a message on Facebook, depending 
on the number of people who like your post, 
Facebook displays different information.

If no one likes your post, it doesn't display anything.

If only one person likes your post, it displays: 
[Friend's Name] likes your post.

If two people like your post, it displays: 
[Friend 1] and [Friend 2] like your post.

If more than two people like your post, 
it displays: [Friend 1], [Friend 2] and 
[Number of Other People] others like your post.

Write a program and continuously ask the user 
to enter different names, until the user presses 
Enter (without supplying a name). Depending on the 
number of names provided, display a message 
based on the above pattern.
*/

Console.WriteLine("Insert the name of all the people that liked your Facebook post, one by one. Press Enter when you are done. 🤗\n");

var names = new List<string>();

while (true) {
	Console.Write("Insert name (or Enter if you are done): ");
	var name = Console.ReadLine();
	if (name == "") break;
	
	names.Add(name);
}

var numberOfNames = names.Count;

if (numberOfNames == 1) {
	Console.WriteLine($"\n{names[0]} likes your post.");
} else if (numberOfNames == 2) {
	Console.WriteLine($"\n{names[0]} and {names[1]} like your post.");
} else if (numberOfNames > 2) {
	Console.WriteLine($"\n{names[0]}, {names[1]} and {numberOfNames - 2} others like your post.");
}