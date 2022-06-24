using dotNetExercises.Algorithm1;
using FluentAssertions;
using Xunit;

namespace dotNetExercises.Tests.Algorithm1Tests;

public class StringSubsetsTests
{
	[Fact]
	public void empty_set_returns_1_subset()
	{
		// act
		const string input = "";

		var subsetsCount = 1 << input.Length;
		var subsets = new[] { "" };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}

	[Fact]
	public void set_with_one_element_returns_2_subsets()
	{
		// act
		const string input = "a";

		var subsetsCount = 1 << input.Length;
		var subsets = new[] { "", "a" };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}

	[Fact]
	public void set_with_n_unique_elements_returns_2_to_the_power_of_n_subsets()
	{
		// act
		const string input = "abcd";

		var subsetsCount = 1 << input.Length;
		var subsets = new[] { "", "a", "b", "c", "d", "ab", "ac", "ad",
			"bc", "bd", "cd", "abc", "abd", "acd", "bcd", "abcd"  };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}

	[Fact]
	public void set_with_n_the_same_elements_returns_n_plus_1_subsets()
	{
		// act
		const string input = "aa";

		var subsetsCount = 3;
		var subsets = new[] { "", "a", "aa" };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}

	[Fact]
	public void set_with_repeated_chars_1()
	{
		// act
		const string input = "aba";

		var subsetsCount = 6;
		var subsets = new[] { "", "a", "b", "ab", "aa", "aab" };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}

	[Fact]
	public void set_with_repeated_chars_2()
	{
		// act
		const string input = "aabb";

		var subsetsCount = 9;
		var subsets = new[] { "", "a", "b", "aa", "ab", "bb", "aab", "abb", "aabb" };

		// act
		var result = StringSubsets.FindSubsets(input);

		// assert
		result.Count.Should().Be(subsetsCount);
		result.Should().Contain(subsets);
	}
}