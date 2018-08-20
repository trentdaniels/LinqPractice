using System;
using System.Collections.Generic;

namespace LinqPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> listOfWords = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            IEnumerable<string> wordsWithTH = new SubstringTH().FindTH(listOfWords);
            Console.WriteLine("Problem 1:");
            foreach (string word in wordsWithTH)
            {
                Console.WriteLine(word);
            }

            List<string> listWithDuplicates = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            IEnumerable<string> listWithoutDuplicates = new DeDuplicator().RemoveDuplicates(listWithDuplicates);
            Console.WriteLine("Problem 2:");
            foreach (string name in listWithoutDuplicates)
            {
                Console.WriteLine(name);
            }

            List<string> listOfGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            double classAverage = new Grades().GetClassAverage(listOfGrades);
            Console.WriteLine("Problem 3:");
            Console.WriteLine(classAverage);


            string nameWithoutFrequency = "Terrill";
            string nameFrequency = new LetterFrequency().GetFrequency(nameWithoutFrequency);
            Console.WriteLine(nameFrequency);

        }
    }
}
