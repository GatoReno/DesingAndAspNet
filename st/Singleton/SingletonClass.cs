using System;
namespace st.Singleton
{
    public class SingletonClass
    {
        private readonly static SingletonClass _instance = new SingletonClass();
        public static SingletonClass Instance
        {
            get { return _instance; }
        }
        private SingletonClass()
        {

        }
    }
}
