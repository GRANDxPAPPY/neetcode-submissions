public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (Dfs(board, word, 0, i, j, m, n)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    private bool Dfs(char[][] board, string word, int index, int row, int col, int m, int n) {
        // 1. Bounds check
        if (row < 0 || row >= m || col < 0 || col >= n) {
            return false;
        }
        
        // 2. Character match check
        if (board[row][col] != word[index]) {
            return false;
        }
        
        // 3. Success check (last character matched)
        if (index == word.Length - 1) {
            return true;
        }
        
        // 4. Mark as visited
        char temp = board[row][col];
        board[row][col] = '#';
        
        // 5. Explore all 4 directions
        bool found = Dfs(board, word, index + 1, row - 1, col, m, n) ||  // up
                     Dfs(board, word, index + 1, row + 1, col, m, n) ||  // down
                     Dfs(board, word, index + 1, row, col - 1, m, n) ||  // left
                     Dfs(board, word, index + 1, row, col + 1, m, n);    // right
        
        // 6. Backtrack (unmark)
        board[row][col] = temp;
        
        return found;
    }
}
