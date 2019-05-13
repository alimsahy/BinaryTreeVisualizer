/*
 * 
 * Create by Alimsah YILDIRIM on 3/5/2019
 * 
 * @file        TreeNode.cs
 * @url         github.com/alimsahy/BinaryTreeVisualizer
 * 
 * 
*/

namespace RedBlackTree
{
    public class TreeNode
    {
        /// <summary>
        ///     Gets or sets the item.
        /// </summary>
        /// <value>The item.</value>
        public int Item { get; set; }

        /// <summary>
        ///     Gets or sets the left.
        /// </summary>
        /// <value>The left.</value>
        public TreeNode Left { get; set; }

        /// <summary>
        ///     Gets or sets the right.
        /// </summary>
        /// <value>The right.</value>
        public TreeNode Right { get; set; }

        /// <summary>
        ///     Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        public TreeNodeColor Color { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:RedBlackTree.TreeNode"/> class.
        /// </summary>
        /// <param name="value">Value.</param>
        public TreeNode(int value)
        {
            Item = value;
        }
    }
}
