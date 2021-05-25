using System;

namespace Delegates_Example_3
{
    public delegate string MessageDelegate(string name);
    class LambdaExpressions
    {
        static void Main(string[] args)
        {
            MessageDelegate obj = (name) =>                         //Lambda Expression
            {
                return "Hai " + name;
            };
            string str = obj.Invoke("Rohit");
            Console.WriteLine(str);
        }
    }
}
