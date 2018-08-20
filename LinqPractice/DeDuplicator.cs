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
            var listWithoutDuplicates = list.OrderBy(word=> word).Where(word => RemoveItem(list, word).Contains(word) == false);
            return listWithoutDuplicates;
        }

        private List<string> RemoveItem(List<string> list, string word) 
        {
            list.Remove(word);
            return list;
        }
    }
}
