// See https://aka.ms/new-console-template for more information


string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] words = sentence.Split(" ");

foreach (string phrase in words)
{
    Console.WriteLine(phrase);
}

Type t = typeof(phrase);
Console.WriteLine(t.ToString());


//Console.WriteLine(string.Join(",", words));










