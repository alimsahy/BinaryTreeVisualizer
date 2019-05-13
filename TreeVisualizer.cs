/*
 * 
 * Create by Alimsah YILDIRIM on 3/5/2019
 * 
 * @file        TreeVisualizer.cs
 * @url         github.com/alimsahy/BinaryTreeVisualizer
 * 
 * 
*/

namespace RedBlackTree
{
    using System;
    using System.Collections.Generic;

    public static class TreeVisualizer
    {
        /// <summary>
        ///     The default background.
        /// </summary>
        private static readonly ConsoleColor DEFAULT_BACKGROUND = Console.BackgroundColor;

        /// <summary>
        ///     Print the specified root, topMargin and leftMargin.
        /// </summary>
        /// <param name="root">Root.</param>
        /// <param name="topMargin">Top margin.</param>
        /// <param name="leftMargin">Left margin.</param>
        public static void Print(this TreeNode root, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;

            int rootTop = Console.CursorTop + topMargin;
            List<VisualTreeNode> last = new List<VisualTreeNode>();
            TreeNode next = root;

            for (int level = 0; next != null; level++)
            {
                VisualTreeNode item = new VisualTreeNode()
                {
                    Node = next,
                    Text = next.Item.ToString(" 0 ")
                };

                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + 1;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }

                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.Left)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos);
                    }
                }

                next = next.Left ?? next.Right;

                for (; next == null; item = item.Parent)
                {
                    Print(item, rootTop + 2 * level);

                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos;
                        next = item.Parent.Node.Right;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                        {
                            item.Parent.EndPos = item.StartPos;
                        }
                        else
                        {
                            item.Parent.StartPos += (item.StartPos - item.Parent.EndPos) / 2;
                        }
                    }
                }
                Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
            }
        }

        /// <summary>
        ///     Print the specified item and top.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="top">Top.</param>
        private static void Print(VisualTreeNode item, int top)
        {
            SwapColors();
            if (item.Node.Color == TreeNodeColor.Black) Console.BackgroundColor = ConsoleColor.DarkGray;
            if (item.Node.Color == TreeNodeColor.Red) Console.BackgroundColor = ConsoleColor.Red;
            Print(item.Text, top, item.StartPos);
            SwapColors();

            if (item.Left != null)
            {
                PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
            }

            if (item.Right != null)
            {
                PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
            }
        }

        /// <summary>
        ///     Print the specified text, top, left and right.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="top">Top.</param>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
        private static void Print(string text, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0)
            {
                right = left + text.Length;
            }

            while (Console.CursorLeft < right)
            {
                Console.Write(text);
            }
        }

        /// <summary>
        /// P   rints the link.
        /// </summary>
        /// <param name="top">Top.</param>
        /// <param name="start">Start.</param>
        /// <param name="end">End.</param>
        /// <param name="startPos">Start position.</param>
        /// <param name="endPos">End position.</param>
        private static void PrintLink(int top, string start, string end, int startPos, int endPos)
        {
            Print(start, top, startPos);
            Print("-", top, startPos + 1, endPos);
            Print(end, top, endPos);
        }

        /// <summary>
        ///     Swaps the colors.
        /// </summary>
        private static void SwapColors()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = DEFAULT_BACKGROUND;
        }
    }
}
