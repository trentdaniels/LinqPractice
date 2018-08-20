using System;
using System.Linq;

namespace LinqPractice
{
    public class LetterFrequency
    {
        public LetterFrequency()
        {
        }

        public string GetFrequency(string word)
        {
            //var wordWithFreqency = word.Split().OrderBy(character => character).Select(w => w.Distinct().Concat(w.Count().ToString()).ToList());
            //var wordWithFreqency = word.Split().OrderBy(character => character).Aggregate((current, next) => current + current.Count().ToString() + next);
            var wordWithFreqency = string.Join("", word.ToUpper().Select(w => $"{w}{word.ToUpper().Count(y => y == w)}").Distinct().OrderBy(w => w));

            return wordWithFreqency;
        }
    }
}
