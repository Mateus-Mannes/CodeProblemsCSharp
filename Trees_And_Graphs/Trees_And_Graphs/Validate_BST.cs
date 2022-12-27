namespace Trees_And_Graphs
{
    public static class Validate_BST
    {
        public static bool Run(Node head)
        {
            int maxLeft = GetMax(head.Children.First());    
            int minRight = GetMin(head.Children.Last());
            if(maxLeft > head.Value || minRight < head.Value) return false;
            return true;
        }

        public static int GetMax(Node head)
        {
            if (!head.Children.Any()) return head.Value;
            int maxLeft = GetMax(head.Children.FirstOrDefault());
            int maxRight = -1;
            if(head.Children.Count == 2) maxRight = GetMax(head.Children.LastOrDefault());
            if (maxLeft > head.Value) return int.MaxValue;
            if(maxLeft > maxRight) return maxLeft;
            return maxRight;    
        }

        public static int GetMin(Node head)
        {
            if (!head.Children.Any()) return head.Value;
            int minLeft = GetMin(head.Children.FirstOrDefault());
            int minRight = int.MaxValue;
            if (head.Children.Count == 2) minRight = GetMin(head.Children.LastOrDefault());
            if (minRight < head.Value) return int.MinValue;
            if (minLeft < minRight) return minLeft;
            return minRight;
        }

    }
}
