using System; // Systme 생략 가능
using static System.Console; // System.Console 생략 가능

namespace Hello
{
    internal class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args) // Main 메서드가 종료 되면 프로그램도 같이 종료됨
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }
            WriteLine("Hello, {0}", args[0]); // Hello,World를 프롬프트에 출력
        }
    }
}
