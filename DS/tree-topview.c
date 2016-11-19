/*
struct node
{
    int data;
    node* left;
    node* right;
};

*/

void top_view(node * root) {

    if (root->left) {
        root->left->right = NULL;
        top_view(root->left);
    }

    printf("%d ", root->data);

    if (root->right) {
        root->right->left = NULL;
        top_view(root->right);
    }
}