using System;
using System.Text.RegularExpressions;
namespace TelestraTest
{
	public class Path
	{
		public string CurrentPath { get; private set; }
		public Path(string path)
		{
			this.CurrentPath = path;
		}

		/// <summary>
		/// Change the directory to the new path specified
		/// </summary>
		/// <param name="newPath">New path.</param>
		public Path Cd(string newPath)
		{
			Path retVal = null;
			try
			{
				if (Regex.IsMatch(newPath, @"^\.{2}/[a-z]+")) //Check for valid path
				{
					var DestPath = newPath.Substring (newPath.LastIndexOf ('/'));
					if (string.Compare (CurrentPath, "/") == 0)  //checking root directory 
					{
						//if CurrentPath is root directory, add the new directory name after root
						string retPath = CurrentPath+DestPath.Replace("/",string.Empty);
						retVal= new Path (retPath); 
					}
					//Take the parent path from current path 
					var CurrentParentPath = CurrentPath.Substring (0, CurrentPath.LastIndexOf ('/'));
					var returnPath= CurrentParentPath+DestPath;
					retVal= new Path (returnPath); 
				}
				else
				{
					Console.WriteLine("Invalid Path Entered");
				}
			}
			catch (ApplicationException e)
			{
				Console.WriteLine("Exception: {0}", e.Message);
			}
			return retVal;
		} 
	}
}

