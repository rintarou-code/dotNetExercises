namespace dotNetExercises.Algorithm1;

public class StringSubsets
{
	private const string EmptySet = "";

	public static ISet<string> FindSubsets(string input)
	{
		var subsetsCount = 1 << input.Length;
		var subsets = new HashSet<string> { EmptySet };

		var numbers = Enumerable.Range(1, subsetsCount - 1);

		foreach (var number in numbers)
		{
			var output = input
				.Where((_, index) => (number & (1 << index)) != 0)
				.OrderBy(c => c);

			subsets.Add(new string(output.ToArray()));
		}

		return subsets;
	}
}