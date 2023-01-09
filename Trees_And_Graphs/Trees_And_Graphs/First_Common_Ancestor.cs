using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class First_Common_Ancestor
    {
        public static Node Run(Node n1, Node n2)
        {
            // calculate height of both nodes
            int n1H = GetHeghit(n1);
            int n2H = GetHeghit(n2);
            // igualate them
            int diff = Math.Abs(n1H - n2H);
            if (n1H > n2H) GoUp(ref n1, diff);
            else GoUp(ref n2, diff);
            // iterate to parents until they are equal
            while(n1 != n2)
            {
                n1 = n1.Parent;
                n2 = n2.Parent;
            }
            return n1;
        }

        private static int GetHeghit(Node n)
        {
            int height = 0;
            while (n.Parent != null)
            {
                n = n.Parent;
                height++;
            }
            return height;
        }

        private static void GoUp(ref Node n, int positions)
        {
            while(positions > 0)
            {
                n = n.Parent;
                positions--;
            }
        }
    }
}
