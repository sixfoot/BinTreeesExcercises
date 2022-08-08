using BinaryTreeExcercises;
namespace TestTrees
{
    [TestClass]
    public class UnitTestTraversal
    {

        /// <summary>
        /// Generates basic tree [1,null,2,3] 
        /// </summary>
        /// <returns>
        ///         1
        ///            2
        ///         3  
        /// </returns>
        private TreeNode GenerateBasicTree()
        {
            return new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
        }
        [TestMethod]
        public void TestPreorder()
        {
            TreeNode root = GenerateBasicTree();
            Solution solution = new Solution();
            var result = solution.PreorderTraversal(root);
            List<int> expected = new List<int> { 1, 2, 3 };
            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [TestMethod]
        public void TestPreorderRecursive()
        {
            TreeNode root = GenerateBasicTree();
            Solution solution = new Solution();
            List<int> result = new List<int>();
            solution.PreorderTraversalRecursive(root, ref result);
            List<int> expected = new List<int> { 1, 2, 3 };
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}