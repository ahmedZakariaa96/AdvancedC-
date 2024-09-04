using System;

public static class StringExtenstion
{
	public static string RemoveWhiteSpace(this string value )
	{
        return value.Replace(" ","");
	  
	}

	public static string? Reverse( this string value )
	{
		var charArray=value.ToCharArray();
		 Array.Reverse(charArray);
		return new string(charArray);
	}
}
