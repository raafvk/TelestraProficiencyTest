
using System;
using System.Text.RegularExpressions;

namespace TelestraTest
{
	public class Run
	{
		/// <summary>
		/// To find the Index the of longest run in the given string
		/// </summary>
		/// <returns>Index of longest run.</returns>
		/// <param name="str">String.</param>
		public static int IndexOfLongestRun(string str)
		{
			int longestIndex = -1; 
			try
			{
				if(!string.IsNullOrEmpty(str))
				{
					Regex reg = new Regex(@"(\w)\1+"); //Expression for finding one or more run
					MatchCollection matches = reg.Matches(str);
					int longest = 0;
					//Traverse through the collection of runs and find the longestIndex
					foreach (Match match in matches)
					{
						if (longest < match.Length)
						{
							longest = match.Length;
							longestIndex = match.Index;
						}
					}
				}
				else
				{
					Console.WriteLine("Error: Empty string");
				}
				return longestIndex;
			}
			catch (ApplicationException e)
			{
				Console.WriteLine("Exception: {0}", e.Message);
				return longestIndex;
			}
		}
	}
}

