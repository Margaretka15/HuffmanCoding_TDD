using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HuffmanCoding
{
    public class HuffmanCoding
    {
        public static void Main(string[] args)
        {
            string outputFileName = "result.ghf";

            string fileName = args[0];
            var file = File.ReadAllText(fileName);
            Console.WriteLine(file);

            if(file.Length == 0)
            {
                return;
            }

            var r = Tokenizer.countCharacters(file);
            var t = HuffmanTree.EncodeCharacters(r);

            Console.WriteLine("Codes:");
            foreach (var kvp in t)
            {
                Console.WriteLine("Character = {0}, Code = {1}", kvp.Key, kvp.Value);
            }

            var outputBytes = FileEncoder.EncodeFile(t, file);

            using (var fs = new FileStream(outputFileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(outputBytes.ToArray(), 0, outputBytes.Count());
            }

            Console.ReadKey();
        }
    }
    
    
}