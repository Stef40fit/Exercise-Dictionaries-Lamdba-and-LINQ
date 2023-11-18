Dictionary<string, int> resourses = new();
string resours = Console.ReadLine();
while(resours != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resourses.ContainsKey(resours))
    {
        resourses.Add(resours, quantity);
    }
    else
    {
        resourses[resours] += quantity;
    }
    resours = Console.ReadLine();
}
foreach(KeyValuePair<string, int> pair in resourses)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
