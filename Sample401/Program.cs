// See https://aka.ms/new-console-template for more information

namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;

            // 1つ目のPersonクラスのメソッドのインスタンスを生成
            p1 = new Person();

            // 2つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();

            p1.name = "山田太郎";   // フィールドnameに値を代入
            p1.age = 19;           // フィールドageに値を代入

            // メソッドでnameとageを設定
            p2.SetAgeAndNAme("佐藤花子", 23);

            // それぞれのインスタンスのnameとageを表示
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}