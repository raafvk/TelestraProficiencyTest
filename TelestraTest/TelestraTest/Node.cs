using System;

namespace TelestraTest
{
	public class Node
	{
		public int Value { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }
		public Node(int value, Node left, Node right)
		{
			Value = value;
			Left = left;
			Right = right;
		}
	}

	public class BinarySearchTree
	{
		/// <summary>
		/// Determines if a tree is a valid BST or not.
		/// </summary>
		/// <returns><c>true</c> if the tree is a valid BST; otherwise, <c>false</c>.</returns>
		/// <param name="root">Root node of the tree.</param>
		public static bool IsValidBST(Node root)
		{
			try
			{	
				if (root == null) 
					return(true); 

				//check if the root node's value is less than or equal to  left //child node's biggest value
				if (root.Left != null) 
				{
					int leftChildMaxVal = SubNodeMaxValue (root.Left);
					if (root.Value < leftChildMaxVal)
						return(false); 
				}
				//check if the root node's value is greater than or equal to right //child node's smallest value
				if (root.Right != null) 
				{
					int rightChildMinVal = SubNodeMinValue (root.Right);
					if (root.Value > rightChildMinVal)
						return(false); 
				}
				//Recursively checking the validity
				if (!IsValidBST(root.Left) || !IsValidBST(root.Right)) 
					return(false); 

				return(true); 
			}
			catch (ApplicationException e)
			{
				Console.WriteLine("Exception: {0}", e.Message);
				return(false);
			}
		}



		//To find the biggest value of sub node
		static int SubNodeMaxValue (Node node)
		{
			int childMaxVal = 0;
			int maxvalue = 0;
			if (node.Right == null) 
			{
				childMaxVal = node.Value;
			}
			else 
			{
				childMaxVal = SubNodeMaxValue (node.Right);
			}
			if (node.Value > childMaxVal) 
			{
				maxvalue = node.Value;
			}
			else 
			{
				maxvalue = childMaxVal;
			}

			return maxvalue;
		}


		//To find the smallest value of sub node
		static int SubNodeMinValue (Node node)
		{
			int childMinValue = 0;
			int minValue = 0;
			if (node.Left == null) 
			{
				childMinValue = node.Value;
			}
			else 
			{
				childMinValue = SubNodeMinValue (node.Left);
			}
			if (node.Value < childMinValue) 
			{
				minValue = node.Value;
			}
			else 
			{
				minValue = childMinValue;
			}
			return minValue;
		} 
	}
}

