using System;
namespace FirstProject
{
	public class Mammal
	{
		String outerCovering;

		public Mammal() {
		}

		public Mammal(String outerCovering)
		{
			this.outerCovering = outerCovering;
		}

		// Must use virtual keyword in method signature for the method to be overriden
		public virtual void Hide()
		{
			Console.WriteLine("Hide from predators.");
		}
	}
}

