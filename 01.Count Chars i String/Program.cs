//Create a program that counts all characters in a string, except for space (' '). 
//Print all the occurrences in the following format:
//"{char} -> {occurrences}"

Dictionary<char, int> characters = new ();
string input = Console.ReadLine ();

foreach(char ch in input)
{
    if (ch == ' ')
    {
        continue;
    }
    if(!characters.ContainsKey(ch))
    {
        characters.Add(ch, 1);
    }
    else
    {
        characters[ch]++;
    }
}
foreach(KeyValuePair<char, int> pair in characters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
