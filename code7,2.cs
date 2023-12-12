var grades = new Dictionary<string, List<double>>();
var n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var tokens = Console.ReadLine().Split();
    var name = tokens[0];
   var grade = double.Parse(tokens[1]);
    if (!grades.ContainsKey(name))
        grades[name] = new List<double>();
    grades[name].Add(grade);
}
foreach (var pair in grades)
{
    var name = pair.Key;
    var studentGrades = pair.Value;
    var average = studentGrades.Average();
    Console.Write($"{name} -> ");
    foreach (var grade in studentGrades)
        Console.Write($"{grade:f2} ");
    Console.WriteLine($"(avg: {average:f2})");
}