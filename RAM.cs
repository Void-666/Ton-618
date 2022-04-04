using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ozuTest
{
    class Program
    {
        static List<MyBuffer> buffer = new List<MyBuffer>();
        static void Main(string[] args)
        {
            while (true)
            {
                MyBuffer buf = new MyBuffer();
                buffer.Add(buf);
                Console.WriteLine("Welcome to TON 618!");
            }

        }
    }

    class MyBuffer
    {
        byte[] buf = new byte[1048576];
    }
}