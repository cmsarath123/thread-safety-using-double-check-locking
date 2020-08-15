using System;
using System.Collections.Generic;
using System.Text;

namespace singletondemo
{
    public class Singleton
    {
        private static int ObjectsCount = 0;
        public static Singleton instance = null;
        private static readonly object padlock = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            ObjectsCount++;
            Console.WriteLine($"instances {ObjectsCount}");
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
