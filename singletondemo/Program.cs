using System;

namespace singletondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton _singletonObj = Singleton.GetInstance;
            _singletonObj.WriteMessage("hello world");
            Singleton _anotherObj = Singleton.GetInstance;
            _anotherObj.WriteMessage("how are you");
        }
    }
}
