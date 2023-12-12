int n = int.Parse(Console.ReadLine());
var dickt = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string[] place = Console.ReadLine().Split();
    string place1 = (place[0]);
    string place2 = (place[1]);
    if (place1 == "mineral")
    {
        if (dickt.ContainsKey(place2))
        {
            dickt[place2]++;
        }
        else
        {
            dickt[place2] = 1;
        }
    }
}
var orderedCounts = dickt.OrderBy(pair => pair.Key);
foreach (var pair in orderedCounts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
}