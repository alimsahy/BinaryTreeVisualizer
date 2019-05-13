/*
 * 
 * Create by Alimsah YILDIRIM on 3/5/2019
 * 
 * @file        VisualTreeNode.cs
 * @url         https://github.com/alimsahy/BinaryTreeVisualizer
 * 
 * 
*/

namespace RedBlackTree
{
    public class VisualTreeNode
    {
        /// <summary>
        ///     Gets or sets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public VisualTreeNode Parent { get; set; }

        /// <summary>
        ///     Gets or sets the left.
        /// </summary>
        /// <value>The left.</value>
        public VisualTreeNode Left { get; set; }

        /// <summary>
        ///     Gets or sets the right.
        /// </summary>
        /// <value>The right.</value>
        public VisualTreeNode Right { get; set; }

        /// <summary>
        ///     Gets or sets the node.
        /// </summary>
        /// <value>The node.</value>
        public TreeNode Node { get; set; }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }

        /// <summary>
        ///     Gets or sets the start position.
        /// </summary>
        /// <value>The start position.</value>
        public int StartPos { get; set; }

        /// <summary>
        ///     Gets the size.
        /// </summary>
        /// <value>The size.</value>
        public int Size
        {
            get
            {
                return Text.Length;
            }
        }

        /// <summary>
        ///     Gets or sets the end position.
        /// </summary>
        /// <value>The end position.</value>
        public int EndPos
        {
            get
            {
                return StartPos + Size;
            }
            set
            {
                StartPos = value - Size;
            }
        }
    }
}
