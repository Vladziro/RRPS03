using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object _lock = new object();

        private Singleton(){}

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something....");
        }
    }
}
