using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatterns
{
    class Singleton
    {
        private int value = 10;
        private Singleton() { }

        public static Singleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly Singleton instance = new Singleton();
        }
        public void Increment()
        {
            value++;
        }
        public int Value { get { return value; } }
    }
}
