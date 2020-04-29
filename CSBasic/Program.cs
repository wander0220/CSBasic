using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //273;
            var name = "김" + "수" + "현";
            Console.Write("Hello C#~!");
            int add=2;
            int _Alpha=33;
            //int 1234A;
            Console.WriteLine("Hello World"); //줄바꿈 함.
            Console.Write("Hello~!"); //얘는 줄바꿈 안함
            Console.WriteLine(1 + 7 + 13);

            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("미림\t마이스터고");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가" + "나" + "다");

            Console.WriteLine(true);
            Console.WriteLine(false);

            int a = 2000000000;
            int b = 1000000000;

            Console.WriteLine((long)a + b);
            Console.WriteLine((long)a + (long)b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine(a + b);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine(sizeof(char));

            for(int i= '가'; i < '갹'; i++)
            {
                Console.Write((char)i);
            }

            //var는 컴파일 할 때 int로 됨. 맨처음에 지정한 데이터 타입으로 쭉 감.
            var number = 100;
            var myName = "김수현이쥐..내이름";
            Console.WriteLine(number);
            Console.WriteLine(myName);

            string input = Console.ReadLine();
            Console.WriteLine("입력 : " + input);

        }
    }
}
