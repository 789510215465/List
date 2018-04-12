using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // list
            List<string> members = new List<string>();
            members.Add("Kim Jong Il");
            members.Add("Xi Jinping");
            members.Add("Donald Trump");
            Console.WriteLine(members[0]);

            // 拿掉list內第一個
            members.RemoveAt(0);
            Console.WriteLine(members[0]);

            // 某個(會重複的)亂數產生器程式碼(請看下面)

            // Random rand = new Random();
            // for(int i = 0 ; i < 6 ; i++ )
            // {
            //    int r0 = rand.Next(1, 43);
            //    int r1 = rand.Next(1, 43);
            //    int r2 = rand.Next(1, 43);
            //    int r3 = rand.Next(1, 43);
            //    int r4 = rand.Next(1, 43);
            //    int r5 = rand.Next(1, 43);
            //   Console.WriteLine(" {0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ", r0 , r1 , r2 , r3 , r4 , r5 );
            // }

            
            Console.ReadLine();
        }
    }
}
