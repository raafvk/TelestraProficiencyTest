using System;

namespace TelestraTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Question1
			var result = MathUtils.Average (1, 2);
			Console.WriteLine ("Average is  :{0}", result);

			//Question2
//			Path path = new Path("/a/b/c/d");
//			Path newPath= path.Cd("../xyz");
//			if (newPath != null) 
//			{
//				Console.WriteLine (newPath.CurrentPath);
//			}

			//Question3
//			Console.WriteLine(Run.IndexOfLongestRun("abbcccddddcccbba"));

			//Question4
//			Node n1 = new Node(1, null, null);
//			Node n3 = new Node(3, null, null);
//			Node n2 = new Node(2, n1, n3);
//			Console.WriteLine(BinarySearchTree.IsValidBST(n2));
		}
	}
}
