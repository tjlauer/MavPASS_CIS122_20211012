using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211012
{
	// Create a Queue using Stacks
	public class myQueue
	{
		private Stack<string> stack1 = new Stack<string>();
		private Stack<string> stack2 = new Stack<string>();

		public void Enqueue(string aString)
		{
			stack1.Push(aString);
		}

		public string Dequeue()
		{
			// Reverse stack1 into stack2
			int stack1Count = stack1.Count;
			for(int i = 0; i < stack1Count; i++)
			{
				stack2.Push(stack1.Pop());
			}

			string returnValue = stack2.Pop();

			for (int i = 0; i < stack1Count - 1; i++)
			{
				stack1.Push(stack2.Pop());
			}

			return returnValue;
		}
	}
}
