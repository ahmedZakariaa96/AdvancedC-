using System;

public static class NumberExtenstion
{
	public static bool IsBetween(int value, int min,int max)
	{
		return (value >= min && value <= max);
	}
}
