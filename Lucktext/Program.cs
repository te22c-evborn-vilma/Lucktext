// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, what is your name?");

string name = Console.ReadLine();

Console.WriteLine("Hi " + name + "! Please write a body part:");

string bodypart = Console.ReadLine();

Console.WriteLine("Thanks! Now write an adjective:");

string adjective1 = Console.ReadLine();

Console.WriteLine("Please write a noun:");

string noun1 = Console.ReadLine();

Console.WriteLine("Thank you, please write a smaller noun:");

string noun2 = Console.ReadLine();

Console.WriteLine("As for the last word, please write an adverb:");

string adverb1 = Console.ReadLine();

Console.WriteLine($"Thank you {name} for helping me with this story. To read our story, please press ENTER ;)");

Console.ReadLine();

Console.WriteLine($"The thing {name} held in their {bodypart} was a {adjective1} metallic {noun1}, scarcely larger than a small {noun2}, and very {adverb1} made.");

Console.ReadLine();