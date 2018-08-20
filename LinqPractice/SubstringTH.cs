using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqPractice
{
    public class SubstringTH
    {
        public SubstringTH()
        {
        }

        public IEnumerable<string> FindTH(List<string> listOfNames)
        {
            var namesWithTH = listOfNames.Where(name => name.Contains("th"));
            return namesWithTH;
        }
    }


}
