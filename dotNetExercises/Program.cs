using dotNetExercises.Algorithm1;

if (args.Length > 0)
{
	var subsets = StringSubsets.FindSubsets(args.First());

	foreach (var subset in subsets)
		Console.WriteLine(subset);
}
else
	Console.WriteLine("invalid input: no arguments");