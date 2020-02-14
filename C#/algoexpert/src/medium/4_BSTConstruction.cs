namespace algoexpert
{
// ​BST Construction

// Write a Binary Search Tree(BST) class. The class should have a "value" property set to be an integer, 
// as well as "left" and "right" properties, both of which should point to either the None(null) value or to 
// another BST.A node is said to be a BST node if and only if it satisfies the BST property: its value is 
// strictly greater than the values of every node to its left; its value is less than or equal to the values 
// of every node to its right; and both of its children nodes are either BST nodes themselves or None(null) values.
// The BST class should support insertion, searching, and removal of values.The removal method should only remove 
// the first instance of the target value.

// Sample input:
//             10
//           /       \
//         5         15
//       /    \     /      \
//     2      5 13     22
//   /                  \
// 1                    14
// Sample output(after inserting 12):
//             10
//           /       \
//         5         15
//       /    \     /      \
//     2      5 13     22
//   /             /    \
// 1          12        14
// Sample output(after removing 10):
//             12
//           /       \
//         5         15
//       /    \     /      \
//     2      5 13     22
//   /                  \
// 1                    14
// Sample output(after searching for 15): True

public partial class Program
    {
        public class BSTConstruction
        {
            public int value;
            public BSTConstruction left;
            public BSTConstruction right;

            public BSTConstruction(int value)
            {
                this.value = value;
            }

            // Average: O(log(n)) time | O(1) space
            // Worst: O(n) time | O(1) space
            public BSTConstruction Insert(int value)
            {
                BSTConstruction currentNode = this;
                while (true)
                {
                    if (value < currentNode.value)
                    {
                        if (currentNode.left == null)
                        {
                            BSTConstruction newNode = new BSTConstruction(value);
                            currentNode.left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            BSTConstruction newNode = new BSTConstruction(value);
                            currentNode.right = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
                return this;
            }

            // Average: O(log(n)) time | O(1) space
            // Worst: O(n) time | O(1) space
            public bool Contains(int value)
            {
                BSTConstruction currentNode = this;
                while (currentNode != null)
                {
                    if (value < currentNode.value)
                    {
                        currentNode = currentNode.left;
                    }
                    else if (value > currentNode.value)
                    {
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }

            // Average: O(log(n)) time | O(1) space
            // Worst: O(n) time | O(1) space
            public BSTConstruction Remove(int value)
            {
                Remove(value, null);
                return this;
            }

            public void Remove(int value, BSTConstruction parentNode)
            {
                BSTConstruction currentNode = this;
                while (currentNode != null)
                {
                    if (value < currentNode.value)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.left;
                    }
                    else if (value > currentNode.value)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        if (currentNode.left != null && currentNode.right != null)
                        {
                            currentNode.value = currentNode.right.getMinValue();
                            currentNode.right.Remove(currentNode.value,
                              currentNode);
                        }
                        else if (parentNode == null)
                        {
                            if (currentNode.left != null)
                            {
                                currentNode.value = currentNode.left.value;
                                currentNode.right = currentNode.left.right;
                                currentNode.left = currentNode.left.left;
                            }
                            else if (currentNode.right != null)
                            {
                                currentNode.value = currentNode.right.value;
                                currentNode.left = currentNode.right.left;
                                currentNode.right = currentNode.right.right;
                            }
                            else
                            {
                                currentNode.value = 0;
                            }
                        }
                        else if (parentNode.left == currentNode)
                        {
                            parentNode.left = currentNode.left !=
                              null ? currentNode.left :
                              currentNode.right;
                        }
                        else if (parentNode.right == currentNode)
                        {
                            parentNode.right = currentNode.left !=
                              null ? currentNode.left :
                              currentNode.right;
                        }
                        break;
                    }
                }
            }

            public int getMinValue()
            {
                if (left == null)
                {
                    return value;
                }
                else
                {
                    return left.getMinValue();
                }
            }
        }
    }
}