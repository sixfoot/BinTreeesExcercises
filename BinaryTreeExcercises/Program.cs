// See https://aka.ms/new-console-template for more information
using BinaryTreeExcercises;

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
		List<int> result = new List<int>();
		var node = root;
		List<TreeNode> nodes = new List<TreeNode>();
		while (node != null || nodes.Count() > 0)
        {
			if (node == null) {
				node = nodes.Last();
				nodes.Remove(node);
				node = node.right;
				continue;
            }
			result.Add(node.val);
			nodes.Add(node);
			node = node.left;
        }
		return result;
	}
	static void Main()
    {
		Solution s = new Solution();
		s.PreorderTraversal(new TreeNode());
    }
}

