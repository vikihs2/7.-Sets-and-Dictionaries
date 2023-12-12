double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
var counts = new Dictionary<double, int>();
foreach (var num in nums)
    if (counts.ContainsKey(num))
        counts[num]++;
    else
        counts[num] = 1;
foreach (var num in counts)
    Console.WriteLine($"{num.Key} - {num.Value} times");