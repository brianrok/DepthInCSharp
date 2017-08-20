using System;
using Depth.MainClasses;
using Depth.GenericeType;

namespace Depth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainProduct1.MyMain();
			System.Console.WriteLine("+++++++++++++++++++++++++++");
            MainProduct2.MyMain();
			System.Console.WriteLine("+++++++++++++++++++++++++++");
            MainProduct3.MyMain();
			System.Console.WriteLine("+++++++++++++++++++++++++++");
            MainProduct4.MyMain();
			System.Console.WriteLine("+++++++++++++++++++++++++++");
			MainGenericType.MyMain();
        }
    }
}
