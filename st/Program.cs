using System;
using st.Singleton;

namespace st
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Design Patterns!");
            var singleton = Singleton.Log.Instance;
            var logx = Singleton.Log.Instance;
            logx.Save("yeah");
        }
    }
}
