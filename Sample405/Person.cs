using System;
namespace Sample405
{
	public class Person
	{
		public void SetAgeAndName(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void ShowAgeAndName()
		{
			Console.WriteLine($"名前：{Name} 年齢：{Age}");
		}

		public string Name
		{
			private set; get;
		}

		public int Age
		{
			set; get;
		}
	}
}
