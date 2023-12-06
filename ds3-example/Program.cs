namespace ds3_example;

internal class TreeExample
{
    internal class Node
    {
         public int value; // The value of the node
         public Node left; // The left child of the node
         public Node right; // The right child of the node
     
         // Constructor to initialize the node with a value
         public Node(int value)
         {
             this.value = value;
             this.left = null;
             this.right = null;
         }
    }

    internal class BST
    {
        private Node root; // The root node of the tree

        // Constructor to initialize the tree with a root node
        public BST(int value)
        {
            root = new Node(value);
        }

        // Method to insert a new node with a given value into the tree
        public void Insert(int value)
        {
            // Start from the root node
            Node current = root;

            // Loop until the insertion is done
            while (true)
            {
                // If the value is less than or equal to the current node's value, go to the left subtree
                if (value <= current.value)
                {
                    // If the left child is null, insert the new node there
                    if (current.left == null)
                    {
                        current.left = new Node(value);
                        break;
                    }
                    // Otherwise, move to the left child and continue the loop
                    else
                    {
                        current = current.left;
                    }
                }
                // If the value is greater than the current node's value, go to the right subtree
                else
                {
                    // If the right child is null, insert the new node there
                    if (current.right == null)
                    {
                        current.right = new Node(value);
                        break;
                    }
                    // Otherwise, move to the right child and continue the loop
                    else
                    {
                        current = current.right;
                    }
                }
            }
        }

        public void Delete(int value)
        {
            // Start from the root node
            Node current = this.root;
            Node parent = null; // The parent of the current node
            bool isLeftChild = false; // Whether the current node is the left child of its parent

            // Loop until the node to be deleted is found or the tree is exhausted
            while (current != null && current.value != value)
            {
                // Update the parent node
                parent = current;

                // If the value is less than the current node's value, go to the left subtree
                if (value < current.value)
                {
                    isLeftChild = true; // The current node is the left child of its parent
                    current = current.left;
                }
                // If the value is greater than the current node's value, go to the right subtree
                else
                {
                    isLeftChild = false; // The current node is the right child of its parent
                    current = current.right;
                }
            }

            // If the node to be deleted is not found, return
            if (current == null)
            {
                return;
            }

            // Case 1: The node to be deleted has no children
            if (current.left == null && current.right == null)
            {
                // If the node to be deleted is the root node, set the root to null
                if (current == this.root)
                {
                    this.root = null;
                }
                // Otherwise, set the parent's child pointer to null
                else
                {
                    if (isLeftChild)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
            }
            // Case 2: The node to be deleted has only one child
            else if (current.left == null || current.right == null)
            {
                // Get the non-null child of the node to be deleted
                Node child = current.left != null ? current.left : current.right;

                // If the node to be deleted is the root node, set the root to the child
                if (current == this.root)
                {
                    this.root = child;
                }
                // Otherwise, set the parent's child pointer to the child
                else
                {
                    if (isLeftChild)
                    {
                        parent.left = child;
                    }
                    else
                    {
                        parent.right = child;
                    }
                }
            }
            // Case 3: The node to be deleted has two children
            else
            {
                // Find the minimum node in the right subtree of the node to be deleted
                Node min = current.right;
                Node minParent = current; // The parent of the minimum node

                // Loop until the minimum node is found
                while (min.left != null)
                {
                    minParent = min;
                    min = min.left;
                }

                // Replace the value of the node to be deleted with the value of the minimum node
                current.value = min.value;

                // Delete the minimum node from the right subtree
                // If the minimum node is the right child of the node to be deleted, set the right child to null
                if (min == current.right)
                {
                    current.right = null;
                }
                // Otherwise, set the minimum node's parent's left child to the minimum node's right child
                else
                {
                    minParent.left = min.right;
                }
            }
        }

        public Node Search(int value)
        {
            // Start from the root node
            Node current = root;

            // Loop until the node is found or the tree is exhausted
            while (current != null)
            {
                // If the value is equal to the current node's value, return the current node
                if (value == current.value)
                {
                    return current;
                }
                // If the value is less than the current node's value, go to the left subtree
                else if (value < current.value)
                {
                    current = current.left;
                }
                // If the value is greater than the current node's value, go to the right subtree
                else
                {
                    current = current.right;
                }
            }

            // If the node is not found, return null
            return null;
        }
    }

    private static void Main()
    {
        BST bst = new BST(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        // Search for some values in the tree
        Node node1 = bst.Search(40); // Found
        Node node2 = bst.Search(90); // Not found

// Delete some values from the tree
        bst.Delete(50); // Delete the root node
        bst.Delete(20); // Delete a leaf node
        bst.Delete(70); // Delete a 
    }
}


// Define a class for a node in the binary search tree


// Define a class for the binary search tree


    // Method to delete a node with a given value from the tree
    

    // Method to search for a node with a given value in the tree
    
}

// Create a binary search tree with some values
