﻿using System;
using System.Collections.Generic;

namespace LinqPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> listOfWords = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics"}
            IEnumerable<string> wordsWithTH = new SubstringTH().FindTH(listOfWords);
            Console.WriteLine("Problem 1:");
            foreach (string word in wordsWithTH)
            {
                Console.WriteLine(word);
            }


        }
    }
}
