public class TicTactToe1275{
    public string Tictactoe(int[][] moves) {
        int n = 3;
        int[] rows = new int[n];
        int[] cols = new int[n];
        int diag = 0;
        int antiDiag = 0;
        int player = 1;
        foreach(var move in moves){
            int row = move[0];
            int col = move[1];
            rows[row]+= player;
            cols[col]+= player;

            if(row == col) diag += player;
            if(row + col == n -1 ) antiDiag += player;
            if(Math.Abs(rows[row]) == n || Math.Abs(cols[col]) == n || Math.Abs(diag) == n || Math.Abs(antiDiag) == n){
                return player == 1 ? "A" : "B";
            }

            player = -player;
        }
        return moves.Length == n * n ? "Draw" : "Pending";
    }
}