using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    public class DeDuplicator
    {
        public DeDuplicator()
        {
        }

        public IEnumerable<string> RemoveDuplicates(List<string> list)
        {
            var listWithoutDuplicates = list.Distinct();
            return listWithoutDuplicates;

        }

        
    }
}
