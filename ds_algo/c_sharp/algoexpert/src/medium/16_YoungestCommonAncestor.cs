namespace algoexpert
{
// Youngest Common Ancestor

// You're given three inputs, all of which are instances of a class that have an "ancestor" property pointing to 
// their youngest ancestor. The first input is the top ancestor in an ancestral tree (i.e., the only instance that 
// has no ancestor), and the other two inputs are descendants in the ancestral tree. Write a function that returns 
// the youngest common ancestor to the two descendants.

// Sample input: Node A, Node E, Node I(from the ancestral tree below)
//             A
//           /     \
//         B C
//       /    \    /    \
//     D E F G
//   /   \
// H I
// Sample output: Node B

public partial class Program
    {
        // O(d) time | O(1) space - where d is the depth (height) of the ancestral tree
        public static AncestralTree GetYoungestCommonAncestor(
            AncestralTree topAncestor,
            AncestralTree descendantOne,
            AncestralTree descendantTwo
            )
        {
            int depthOne = getDescendantDepth(descendantOne, topAncestor);
            int depthTwo = getDescendantDepth(descendantTwo, topAncestor);
            if (depthOne > depthTwo)
            {
                return backtrackAncestralTree(descendantOne, descendantTwo,
                         depthOne - depthTwo);
            }
            else
            {
                return backtrackAncestralTree(descendantTwo, descendantOne,
                         depthTwo - depthOne);
            }
        }

        public static int getDescendantDepth(AncestralTree descendant, AncestralTree topAncestor)
        {
            int depth = 0;
            while (descendant != topAncestor)
            {
                depth++;
                descendant = descendant.ancestor;
            }
            return depth;
        }

        public static AncestralTree backtrackAncestralTree(
            AncestralTree lowerDescendant,
            AncestralTree higherDescendant,
            int diff
            )
        {
            while (diff > 0)
            {
                lowerDescendant = lowerDescendant.ancestor;
                diff--;
            }
            while (lowerDescendant != higherDescendant)
            {
                lowerDescendant = lowerDescendant.ancestor;
                higherDescendant = higherDescendant.ancestor;
            }
            return lowerDescendant;
        }

        public class AncestralTree
        {
            public char name;
            public AncestralTree ancestor;

            public AncestralTree(char name)
            {
                this.name = name;
                this.ancestor = null;
            }

            // This method is for testing only.
            public void AddAsAncestor(AncestralTree[] descendants)
            {
                foreach (AncestralTree descendant in descendants)
                {
                    descendant.ancestor = this;
                }
            }
        }
    }
}