using System;
namespace FirstProject
{
	// Inheritance shown by ":"
	public class Human : Mammal
	{
		int age;
		String name;
		String gender;

		public Human(int age, String name, String gender)
		{
			this.age = age;
			this.name = name;
			this.gender = gender;
		}
		 
		//Overloaded Constructor
		public Human(int age, String name)
		{
			this.age = age;
			this.name = name;
		}


		public void Eat()
		{
			Console.WriteLine("Food eaten.");
		}

		public void Sleep()
		{
			Console.WriteLine("Nap taken.");
		}

		public void Identity(int age, String name)
		{
			this.age = age;
			this.name = name;

			Console.WriteLine($"Hi, I am {name}, and I am {age} years old this year.");
		}

		// Use override keyword when overriding a virtual method
		public override void Hide()
		{
			Console.WriteLine("Humans together strong");
		}
	}
}

