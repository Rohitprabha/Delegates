using System;

namespace Delegates_Example_2
{
    public delegate string MessageDelegate(string name);
    class AnonymousMethods
    {
        //public static string Message(string name)
        //{
        //    return "Hai " + name;
        //}
        static void Main(string[] args)
        {
            //MessageDelegate obj = new MessageDelegate(Message);

            MessageDelegate obj = delegate (string name)                //AnonymousMethod 
            {
                return "Hai " + name;
            };
            string str = obj.Invoke("Rohit");
            Console.WriteLine(str);
        }
    }
}
