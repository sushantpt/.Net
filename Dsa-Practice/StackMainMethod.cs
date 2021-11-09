using System;

namespace Dsa_Practice
{
    class StackMainMethod
    {
        static void Main(string[] args)
        {
            var st = new Stack<int>();
            st.Push(12);
            st.Push(1);
            st.Push(13);
            st.Push(98);
            st.Push(199);

            Console.WriteLine(st);
            Console.WriteLine(st.Pop());   // remove last item(199) and writeLine method returns it

            var forStr = new Stack<string>();
            forStr.Push("Number");
            forStr.Push("Number 1");
            forStr.Push("Number 2");
            Console.WriteLine(forStr.Pop());  // remove last item(Number 2) and writeLine method returns it

        }
    }
}
