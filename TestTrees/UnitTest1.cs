using BinaryTreeExcercises;
namespace TestTrees
{
    [TestClass]
    public class UnitTestTraversal
    {
        [TestMethod]
        public void TestPreorder()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            Solution solution = new Solution();
            var result = solution.PreorderTraversal(root);
            List<int> expected = new List<int> { 1, 2, 3 };
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}