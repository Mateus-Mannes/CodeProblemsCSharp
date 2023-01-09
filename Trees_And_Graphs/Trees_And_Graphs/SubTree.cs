using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class SubTree
    {
        public static bool IsSubTree1(Node n1, Node n2)
        {
            var s1 = new StringBuilder();
            var s2 = new StringBuilder();

            CreatePreOrderString(n1 ,s1);
            CreatePreOrderString(n2, s2);

            return s1.ToString().Contains(s2.ToString());
        }

        public static void CreatePreOrderString(Node node, StringBuilder str)
        {
            if(node == null)
            {
                str.Append('X');
                return;
            }
            str.Append(node.Value);
            CreatePreOrderString(node.Children.FirstOrDefault(), str);
            if (node.Children.Count == 1) CreatePreOrderString(null, str);
            else CreatePreOrderString(node.Children.LastOrDefault(), str);
        }

        public static bool IsSubTree2(Node n1, Node n2)
        {
            if (n2 == null) return true;
            return SubTreeOf(n1, n2);
        }

        public static bool SubTreeOf(Node n1, Node n2)
        {
            if (n1 == null) return false;
            else if (n1.Value == n2.Value && MatchTree(n1, n2)) return true;

            return SubTreeOf(n1.Children.FirstOrDefault(), n2) || (n1.Children.Count > 1 &&
                SubTreeOf(n1.Children.LastOrDefault(), n2));
        }

        public static bool MatchTree(Node n1, Node n2)
        {
            if (n1 == null && n2 == null) return true;
            else if (n1 == null || n2 == null) return false;
            else if (n1.Value != n2.Value) return false;
            else return MatchTree(n1.Children.FirstOrDefault(), n2.Children.FirstOrDefault()) && (
                    MatchTree(n1.Children.Count > 1 ? n1.Children.LastOrDefault() : null, n2.Children.Count > 1 ? n2.Children.LastOrDefault() : null));
        }
    }
}
