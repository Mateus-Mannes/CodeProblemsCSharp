using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class Check_Balanced
    {
        public static bool Run(Node head)
        {
            bool isBalanced = true;
            int height = GetHeight(head, ref isBalanced);
            return isBalanced;
        }

        public static int GetHeight(Node head, ref bool isBalanced)
        {
            if (head == null) return 0;
            int lh = GetHeight(head.Children.FirstOrDefault(), ref isBalanced);
            int rh = head.Children.Count == 2 ? GetHeight(head.Children.LastOrDefault(), ref isBalanced) : 0;
            if(Math.Abs(lh - rh) > 1) isBalanced = false;
            if (lh > rh) return lh + 1;
            else return rh + 1;
        }
    }
}
