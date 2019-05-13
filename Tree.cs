/*
 * 
 * Create by Alimsah YILDIRIM on 3/5/2019
 * 
 * @file        Tree.cs
 * @url         github.com/alimsahy/BinaryTreeVisualizer
 * 
 * 
*/

namespace RedBlackTree
{
    using System;
    using System.Collections.Generic;

    public class Tree : ITree
    {
        private TreeNode m_rootNode;
        private IComparer<int> m_comparer = Comparer<int>.Default;
        private int m_count;

        /// <summary>
        ///     Gets the root.
        /// </summary>
        /// <value>The root.</value>
        public TreeNode Root
        {
            get
            {
                return m_rootNode;
            }
            private set
            {
                m_rootNode = value;
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:RedBlackTree.Tree"/> class.
        /// </summary>
        public Tree()
        {
            m_rootNode = null;
            m_count = 0;
        }

        /// <summary>
        ///     Insert the specified item.
        /// </summary>
        /// <returns>The insert.</returns>
        /// <param name="item">Item.</param>
        public bool Insert(int item)
        {
            if (m_rootNode == null)
            {
                m_rootNode = new TreeNode(item);
                m_rootNode.Color = TreeNodeColor.Black;
                m_count++;
                return true;
            }
            else return InsertSub(m_rootNode, item);
        }

        /// <summary>
        ///     Remove the specified node.
        /// </summary>
        /// <param name="node">Node.</param>
        public void Remove(TreeNode node)
        {
            /// TODO: Implement remove function
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Inserts the sub.
        /// </summary>
        /// <returns><c>true</c>, if sub was inserted, <c>false</c> otherwise.</returns>
        /// <param name="node">Node.</param>
        /// <param name="item">Item.</param>
        private bool InsertSub(TreeNode node, int item)
        {
            if (m_comparer.Compare(node.Item, item) < 0)
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(item);
                    if (node.Color == TreeNodeColor.Black) node.Right.Color = TreeNodeColor.Red;
                    if (node.Color == TreeNodeColor.Red) node.Right.Color = TreeNodeColor.Black;

                    m_count++;
                    return true;
                }
                else return InsertSub(node.Right, item);
            }
            else if (m_comparer.Compare(node.Item, item) > 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(item);
                    if (node.Color == TreeNodeColor.Black) node.Left.Color = TreeNodeColor.Red;
                    if (node.Color == TreeNodeColor.Red) node.Left.Color = TreeNodeColor.Black;

                    m_count++;
                    return true;
                }
                else return InsertSub(node.Left, item);
            }
            else return false;
        }
    }
}
