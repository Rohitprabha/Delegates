using System;

namespace Singlecast_Delegate
{
    public delegate void AddDelegate(int x, int y);             //Defining a delegate
    public delegate string DisplayDelegate(string str);
    class SinglecastDelegate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string Display(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            SinglecastDelegate s = new SinglecastDelegate();
            AddDelegate add = new AddDelegate(s.Add);           //Instantiating the Singlecast delegate
            add(10, 20);
            add.Invoke(10, 20);                                 //Invoke a delegate
            DisplayDelegate dis = new DisplayDelegate(Display);
            Console.WriteLine(dis("Rohit"));
        }
    }
}
