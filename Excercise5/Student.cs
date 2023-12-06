using System;
namespace Excercise5
{
	public class Student
	{
		private string name;
		private int age;
		private string major;

		public Student(string name, int age, string major)
		{
			this.name = name;
			this.age = age;
			this.major = major;
		}

		public void Introduce()
		{
			Console.WriteLine($"Hello! This is {name} of age {age}, studying {major}.");
		}
	}
}

