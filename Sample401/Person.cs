using System;
namespace Sample401
{
	class Person
	{
		// 名前（フィールド）
		public string name = "";

		// 年齢（フィールド）
		public int age = 0;

		// 情報の表示（メソッド）
		public void ShowAgeAndName() {
			Console.WriteLine($"名前：{name} 年齢：{age}");
		}

		// 情報の設定
		public void SetAgeAndNAme(string name, int age) {
			this.name = name;
			this.age = age;
		}
	}
}

