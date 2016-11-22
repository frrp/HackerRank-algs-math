/* 

Tree: Huffman Decoding
-----------------------

The structure of the node is

typedef struct node
{
    int freq;
    char data;
    node * left;
    node * right;
    
}node;

*/

void decode_huff(node * root, string s)
{
    node * ptr; 
    int n;
    ptr = root;
    for (n=0; s[n]; n++)
    {
        ptr = (s[n] == '0') ? ptr->left : ptr->right;
        if(ptr->data)
        {
            cout << ptr->data;
            ptr = root;
        }
    }
}