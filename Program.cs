// Thomas Lauer
// MavPASS CIS 122
// October 12, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavPASS_CIS122_20211012
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Create a stack using queues
			myQueue aQueue = new myQueue();
			aQueue.Enqueue("Joker");
			aQueue.Enqueue("Pengwing");
			aQueue.Enqueue("Nightwin");

			Console.WriteLine(aQueue.Dequeue());
			Console.WriteLine(aQueue.Dequeue());
			Console.WriteLine(aQueue.Dequeue());

			Console.ReadLine();
		}
	}
}
