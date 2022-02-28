using System.Text;

var builder = new StringBuilder();
builder
	.Append('-', 10)
	.AppendLine()
	.Append("Header")
	.AppendLine()
	.Append('-', 10);

Console.WriteLine(builder);

builder.Replace('-', '+');
Console.WriteLine(builder);

builder.Remove(0, 10);
Console.WriteLine(builder);

builder.Insert(0, '*'.ToString(), 10);
Console.WriteLine(builder);

Console.WriteLine("First char: " + builder[0]);