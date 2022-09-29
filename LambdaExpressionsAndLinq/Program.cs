﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4 };
            var result = array.Select(i => i * 2);
            foreach (var i in result) Console.WriteLine(i);
        }
    }
}