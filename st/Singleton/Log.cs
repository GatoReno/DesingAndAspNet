using System;
using System.IO;

namespace st.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string Path = $"log.txt";
        public static Log Instance
        {
            get { return _instance; }
        }
        private Log()
        {

        }

        public void Save(string msn)
        {
            File.AppendAllText(Path, $"{msn} " + Environment.NewLine);
            Console.WriteLine(Path);
        }
    }
}
