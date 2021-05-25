using System;

namespace Delegates
{
    public delegate void MyDelegate(string msg);                                    // declare a delegate
    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(ClassA.MethodA);               // set target method
            //yDelegate del = ClassA.MethodA;
            del("Hello World");                                            // Invoke a delegate


            del = ClassB.MethodB;
            del("Hello World");

            del = (msg) => Console.WriteLine("Called lambda expression: " + msg);           //lambda expression
            del("Hello World");
        }
    }
}
