// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Loop through the string one character at a time,
//Store and/or update the count for a given character using an appropriate data structure.
//Loop through the data structure to print the results (one character and its count per line).

Console.WriteLine("Give me a sentence");
string sentence = Console.ReadLine().ToLower();



//char* filename = "readme.txt";
//File* fp = fopen(filename, "r");

string text = System.IO.File.ReadAllText(@"C:\Users\7teli\Desktop\LaunchCode_Solved_Issue\C_Sharp\control_flow_and_collections\thisisafile.txt");

Console.WriteLine(text);
foreach (char c in text)
{
    if (char.IsLetter(c))
    {
        if (words.ContainsKey(c))
        {
            words[c]++;
        }
        else
        {
            words.Add(c, 1);
        }
    }
}
foreach (KeyValuePair<char, int> pair in words)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}
