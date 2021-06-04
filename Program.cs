using Compilers_LastEight;

namespace full_stack
{
    using System;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {

            CustomStack<char> st = new CustomStack<char>();


            st.Push('C');

            st.TraverseStack(Console.WriteLine);

        }


    }
}
