using System;

Console.WriteLine("=== 인사 테스트 ===");
Console.WriteLine("=== 격식체 ===");
Formal.Message hello1 = new Formal.Message();
Casual.Message hello2 = new Casual.Message();
hello1.SayHello("홍길동");
hello1.SayBye("홍길동");
Console.WriteLine();
Console.WriteLine("[비격식체]");
hello2.SayHello("홍길동");
hello2.SayBye("홍길동");
namespace Formal
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕하십니까!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕히 가십시오!");
        }
    }
}
namespace Casual
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, [{name}]!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, [{name}]!");
        }
    }
}

