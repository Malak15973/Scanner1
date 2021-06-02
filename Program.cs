using System;

namespace full_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<char> st = new CustomStack<char>();


            st.Push('c');

            st.TraverseStack(Console.WriteLine);
        }
    }
}
