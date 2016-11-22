// Binary Search Tree

/*
Node is defined as 

typedef struct node
{
   int data;
   node * left;
   node * right;
}node;

*/

node * insert(node * root, int value)
{
   if (root == NULL) {
      root = (node *)malloc(sizeof(node));
      root->data = value;
      return root;
   }

   if (value < root->data)
       root->left = insert(root->left, value);
   else
       root->right = insert(root->right, value);

   return root;
}


/*
Lowest Common Ancestor
*/

node * lca(node * root, int v1, int v2)
{
    if (v1<root->data && v2<root->data)
        root=lca(root->left,v1,v2);
    else if (v1>root->data && v2>root->data)
        root=lca(root->right,v1,v2);
    return root;
}