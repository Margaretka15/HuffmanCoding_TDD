using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    public class FileEncoder
    {
        public static List<byte> EncodeFile(Dictionary<char, string> t, string file)
        {
            var bytes = new List<byte>();
            Console.WriteLine("Encoded bytes:");
            foreach (var encoding in t)
            {
                bytes.Add(Convert.ToByte(encoding.Key));
                bytes.AddRange(Encoding.ASCII.GetBytes(encoding.Value));
            }

            string result = "";

            foreach (var character in file)
            {
                result += t[character];
            }
            int chunkSize = 8;

            Console.WriteLine(result);
            int length = result.Length;
            if (length % chunkSize != 0)
            {
                result = result.PadRight((length / chunkSize + 1) * chunkSize, '0');
            }

            Console.WriteLine(result);

            List<byte> finalResult = new List<byte>();

            for (int i = 0; i < length; i += chunkSize)
            {
                var chunk = result.Substring(i, chunkSize);
                Console.WriteLine(chunk);
                finalResult.Add(Convert.ToByte(chunk, 2));

            }
            bytes.AddRange(finalResult);

            return bytes;
        }
    }
}
