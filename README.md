# BinaryTreeVisualizer
Basic binary tree visualizer written in C#

# Usage

```csharp
private static Tree m_tree = new Tree();

public static void Main(string[] args)
{
    m_tree.Insert(6);
    m_tree.Insert(9);
    m_tree.Insert(4);
    m_tree.Insert(3);
    m_tree.Insert(5);
    m_tree.Insert(2);
    m_tree.Insert(1);
    m_tree.Insert(8);
    m_tree.Insert(15);
    m_tree.Insert(7);
    m_tree.Insert(21);
    m_tree.Insert(13);

    m_tree.Root.Print();
    Console.ReadKey();
}

```

# Sample Output
![Program Output](output.png)
