using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    public class HuffmanTree
    {
        public class Node
        {
            public char? character { get; set; }
            public int count { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

        }
        public static Dictionary<char, string> EncodeCharacters(Dictionary<char, int> counts)
        {
            List<Node> nodes = new List<Node>();
            foreach (var kvp in counts)
            {
                nodes.Add(new Node { character = kvp.Key, count = kvp.Value });
            }

            List<Node> SortedList = nodes.OrderBy(node => node.count).ToList();
            var rootNode = BuildNodes(SortedList)[0];
            if (rootNode.character != null)
            {
                return GetPath("0", rootNode);
            }
            return GetPath("", rootNode);
        }
        static List<Node> BuildNodes(List<Node> nodes)
        {
            if (nodes.Count == 1)
            {
                return nodes;
            }

            Node newNode = new Node
            {
                count = nodes[0].count + nodes[1].count,
                right = nodes[0],
                left = nodes[1],

            };
            nodes.Remove(nodes[1]);
            nodes.Remove(nodes[0]);

            nodes.Add(newNode);
            return BuildNodes(nodes.OrderBy(node => node.count).ToList());
        }

        static Dictionary<char, string> GetPath(string parentPath, Node node)
        {
            if (node.character != null)
            {
                var dict = new Dictionary<char, string>();
                dict.Add((char)node.character, parentPath);
                return dict;
            }
            else
            {
                var left = GetPath(parentPath + "0", node.left);
                var right = GetPath(parentPath + "1", node.right);
                return left.Concat(right).ToDictionary(x => x.Key, x => x.Value);
            }
        }
    }
}
