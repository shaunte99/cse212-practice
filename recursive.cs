# Recursive function to check if a binary tree is a valid BST

# [H1] Function definition with parameters
def isBST(node, minVal=float('-inf'), maxVal=float('inf')):
    
    # [H2] Base case: An empty tree is a valid BST
    if node is None:
        return True
    
    # [H3] Check if current node's value is within allowed range
    if node.value <= minVal or node.value >= maxVal:
        return False
    
    # [H4] Recursively check left and right subtrees with updated ranges
    return (
        isBST(node.left, minVal, node.value) and
        isBST(node.right, node.value, maxVal)
    )
