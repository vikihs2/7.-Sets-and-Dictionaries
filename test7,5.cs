var names = new HashSet<string>();
var n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var name = Console.ReadLine();
    names.Add(name);
}
foreach (var name in names)
    Console.WriteLine(name);