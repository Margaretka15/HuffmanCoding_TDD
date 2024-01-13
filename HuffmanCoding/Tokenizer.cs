using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    public class Tokenizer
    {
        public static Dictionary<char, int> countCharacters(string text)
        {
            char[] characters = text.ToCharArray();
            var count = characters.GroupBy(tag => tag)
                 .ToDictionary(group => group.Key, group => group.Count());
            foreach (var kvp in count)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            return count;
        }
    }
}
