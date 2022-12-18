using BinaryTreeFromArray;
using static BinaryTreeFromArray.BinaryTree;

var binarytree = new BinaryTree();

var numbers = new List<int>() {10,4,3,5,15,12 };

//foreach (var number in numbers)
//{
//    binarytree.Root = binarytree.BuildBinaryTree(number, binarytree.Root);
//}


binarytree.Root = binarytree.CreateBinaryTree(numbers, 0, numbers.Count-1 );
binarytree.PreOrder(binarytree.Root);