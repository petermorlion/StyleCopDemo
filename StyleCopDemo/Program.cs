// <copyright file="Program.cs" company="RedStar IT">
// Copyright (c) RedStar IT. All rights reserved.
// </copyright>

namespace StyleCopDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Our program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Our main entry point
        /// </summary>
        /// <param name="args">Arguments to be passed to the application</param>
        public static void Main(string[] args)
        {
            Output1();
            Output2();
            Output3();

            Console.ReadLine();
        }

        private static void Output1()
        {
            Console.WriteLine("output 1");
        }

        private static void Output2()
        {
            Console.WriteLine("output 2");
        }

        private static void Output3()
        {
            Console.WriteLine("output 3");
        }
    }
}