/*
 * 
 * Create by Alimsah YILDIRIM on 3/5/2019
 * 
 * @file        ITree.cs
 * @url         github.com/alimsahy/BinaryTreeVisualizer
 * 
 * 
*/

namespace RedBlackTree
{
    public interface ITree
    {
        /// <summary>
        ///     Insert the specified item.
        /// </summary>
        /// <returns>The insert.</returns>
        /// <param name="item">Item.</param>
        bool Insert(int item);

        /// <summary>
        ///     Remove the specified node.
        /// </summary>
        /// <param name="node">Node.</param>
        void Remove(TreeNode node);
    }
}
