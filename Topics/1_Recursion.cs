  public class Recursion_Practice
    {

        public int[] allIndices(int[] arr, int target)
        {
            return allIndicesRec(arr, 0, 0, target);

        }

        //Pepcoding - return All indices
        private int[] allIndicesRec(int[] arr, int idx, int count, int target)
        {
            if (idx == arr.Length - 1)
            {
                return new int[count];
            }

            if (arr[idx] == target)
            {
                int[] arr1 = allIndicesRec(arr, idx + 1, count + 1, target);
                arr1[count] = idx;
                return arr1;
            }
            else
            {
                int[] arr1 = allIndicesRec(arr, idx + 1, count, target);
                return arr1;
            }

        }

        public List<string> GETAllSubsequence(string str)
        {
            if (str.Length == 0)
            {

                return new List<string>() { "" };
            }

            List<string> results = GETAllSubsequence(str.Substring(1));
            List<string> output = new List<string>();
            foreach (var s in results)
            {
                output.Add(str[0] + s);
                output.Add(" " + s);
            }

            return output;

        }

        public string[] keypad = {".;", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tu", "vwx",
                           "yz" };
        public List<string> GetKeyPadCombination(string digits)
        {
            if (digits.Length == 0)
            {

                return new List<string>() { "" };
            }

            List<string> remain = GetKeyPadCombination(digits.Substring(1));
            string first = keypad[Convert.ToInt16(digits.Substring(0, 1))];
            List<string> init = new List<string>();
            foreach (var x in first)
            {
                init.Add(x.ToString());
            }

            List<string> output = new List<string>();
            foreach (var x in first)
            {
                foreach (var y in remain)
                {
                    output.Add(x + y);
                }
            }

            return output;
        }

        // can only take 1,2,3 steps at a time
        public List<string> getAllStairCasePath(int steps)
        {
            if (steps == 0)
            {
                return new List<string>() { "" };
            }
            else if (steps < 0)
            {
                return new List<string>() { };
            }

            List<string> Path1 = getAllStairCasePath(steps - 1);
            List<string> Path2 = getAllStairCasePath(steps - 2);
            List<string> Path3 = getAllStairCasePath(steps - 3);

            List<string> finalPaths = new List<string>();
            foreach (var x in Path1)
            {
                finalPaths.Add("1" + x);
            }
            foreach (var x in Path2)
            {
                finalPaths.Add("2" + x);
            }
            foreach (var x in Path3)
            {
                finalPaths.Add("3" +
                    "" + x);
            }

            return finalPaths;
        }


        // both answers are giving the same timeout error on leetcode because it is not optimised enough
        //we are calculating paths for same coordinates again and again 
        // this can be reduced using dynamic programming (or memoization)
        public int getAllMazePaths(int sr, int sc, int row, int col)
        {
            // this solution is gettin timeout in leetcode
            //if (sr > row - 1 || sc >col-1)
            //{
            //    return 0;
            //}
            //if(sr==row-1 && sc == col - 1)
            //{
            //    return 1;
            //}
            //int hr = getAllMazePaths(sr + 1, sc, row, col);
            //int vr = getAllMazePaths(sr, sc + 1, row, col);
            //return hr + vr;


            // but in this solution we can print all the posible paths
            int hr = 0;
            int vr = 0;

            if (sr == row && sc == col)
            {
                return 1;
            }

            if (sr <= row)
            {
                hr = getAllMazePaths(sr + 1, sc, row, col);
            }

            if (sc <= col)
            {
                vr = getAllMazePaths(sr, sc + 1, row, col);
            }

            return hr + vr;

        }

        // this works to print all the pathss
        public List<string> getAllMazePathsSTRING(int sr, int sc, int row, int col)
        {
            List<string> hr = new List<string>();
            List<string> vr = new List<string>();

            if (sr == row && sc == col)
            {
                return new List<string>() { "." };
            }

            if (sr < row)
            {
                hr = getAllMazePathsSTRING(sr + 1, sc, row, col);
            }
            if (sc < col)
            {
                vr = getAllMazePathsSTRING(sr, sc + 1, row, col);
            }

            List<string> paths = new List<string>();

            foreach (var h in hr)
            {
                paths.Add("h" + h);
            }
            foreach (var v in vr)
            {
                paths.Add("v" + v);
            }

            return paths;
        }

        // this one is a combination of staircase and getall maze paths
        public List<string> getAllMazePathswithJumpSTRING(int sr, int sc, int row, int col)
        {

            List<string> final = new List<string>();

            if (sr == row && sc == col)
            {
                return new List<string>() { "" };
            }

            for (int i = 1; i <= col - sc; ++i)
            {

                var vr = getAllMazePathswithJumpSTRING(sr, sc + i, row, col);
                foreach (var h in vr)
                {
                    final.Add("V" + i.ToString() + h);
                }

            }

            for (int i = 1; i <= row - sr; ++i)
            {

                var hr = getAllMazePathswithJumpSTRING(sr + i, sc, row, col);
                foreach (var h in hr)
                {
                    final.Add("H" + i.ToString() + h);
                }

            }


            for (int i = 1; i <= row - sr && i <= col - sc; ++i)
            {
                var dg = getAllMazePathswithJumpSTRING(sr + i, sc + i, row, col);
                foreach (var h in dg)
                {
                    final.Add("D" + i.ToString() + h);
                }

            }


            return final;
        }

        //----------------- from here on we will work only on printing the subsequence--------------------------------


        public void PrintSS(string ques, string ans)
        {
            if (ques.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }
            char first = ques[0];
            string roq = ques.Substring(1);

            PrintSS(roq, ans + "");
            PrintSS(roq, ans + first.ToString());
        }

        public void PrintKeyPad(string ques, string ans)
        {
            if (ques.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }

            string roq = ques.Substring(1);
            string first = keypad[Convert.ToInt16(ques.Substring(0, 1))];

            foreach (char x in first)
            {
                PrintKeyPad(roq, ans + x);
            }

        }

        public void PrintStairpath(int n, string steps)
        {

            if (n == 0)
            {
                Console.WriteLine(steps);
                return;
            }

            if (n >= 1)
            {
                PrintStairpath(n - 1, steps + "1");
            }
            if (n >= 2)
            {
                PrintStairpath(n - 2, steps + "2");
            }
            if (n >= 3)
            {
                PrintStairpath(n - 3, steps + "3");
            }


        }

        public void PrintMazePaths(int row, int column, int m, int n, string path)
        {

            if (row == m && column == n)
            {
                Console.WriteLine(path);
            }


            if (m < row)
            {
                PrintMazePaths(row, column, m + 1, n, path + "V");
            }
            if (n < column)
            {
                PrintMazePaths(row, column, m, n + 1, path + "H");
            }
        }

        public void PrintMazepathsWithJumps(int row, int column, int m, int n, string path)
        {
            if (m == row && n == column)
            {
                Console.WriteLine(path);
            }

            for (int i = 1; i <= row - m; ++i)
            {
                PrintMazepathsWithJumps(row, column, m + i, n, path + "V" + i.ToString());
            }

            for (int i = 1; i <= column - n; ++i)
            {
                PrintMazepathsWithJumps(row, column, m, n + i, path + "H" + i.ToString());
            }
        }

        public void PrintPermutation(string ques, string ans)
        {
            //No of strings = factorial of length of string

            if (ques.Length == 0)
            {
                Console.WriteLine(ans);
            }

            for (int i = 0; i < ques.Length; ++i)
            {
                var roq = ques.Remove(i, 1);
                PrintPermutation(roq, ans + ques[i]);
            }
        }

        public void PrintEncodings(string ques, string ans)
        {
            if (ques.Length == 0)
            {
                Console.WriteLine(ans);
            }

            for (int i = 0; i < ques.Length; i++)
            {
                int parameter = Convert.ToInt32(ques.Substring(0, i + 1));

                if (parameter < 26 && parameter != 0)
                {
                    string roq = ques.Substring(i + 1);

                    PrintEncodings(roq, ans + (char)(parameter + 96));
                }
                else
                {
                    break;
                }


            }

        }

        public void Floodfill(int[,] maze, int row, int col, bool[,] visited, string psf)
        {

            if (row < 0 || col < 0 || row > maze.GetLength(0) - 1 || col > maze.GetLength(1) - 1 || maze[row, col] == 1 || visited[row, col] == true)
            {
                return;
            }

            if (row == maze.GetLength(0) - 1 && col == maze.GetLength(1) - 1)
            {
                Console.WriteLine(psf);
            }

            visited[row, col] = true;

            Floodfill(maze, row - 1, col, visited, psf + "T");
            Floodfill(maze, row, col - 1, visited, psf + "L");
            Floodfill(maze, row + 1, col, visited, psf + "D");
            Floodfill(maze, row, col + 1, visited, psf + "R");

            visited[row, col] = false; // it is mandatory so that other paths can also be visited



        }

        public void TargetSubset(int[] arr, int target, int sumSF, int index, string ans)
        {
            // this condition whould come at first because in case of 10 50, index will be 
            //greater than target and second condition will return from that point wihout printing it
            if (sumSF == target)

            {
                Console.WriteLine(ans);
                return;
            }

            //second condition
            if (index >= arr.Length)
            {
                return;
            }

            TargetSubset(arr, target, sumSF + arr[index], index + 1, ans + arr[index].ToString() + " ");
            TargetSubset(arr, target, sumSF, index + 1, ans);

        }

        // important concept
        public void NqueensOnBoard(int[,] board, int row, string psf)
        {
            if (row == board.GetLength(0))
            {
                Console.WriteLine(psf);
                return;
            }

            for (int col = 0; col < board.GetLength(0); col++)
            {
                if (isSafeToPlace(board, row, col))
                {
                    // the logic behind setting 1 is that for one row there will be only one queen
                    // and to set it on different columns of first row , we set it 1 and then again set it to zero.

                    board[row, col] = 1;
                    NqueensOnBoard(board, row + 1, psf + row.ToString() + "-" + col.ToString() + ", ");
                    board[row, col] = 0;
                }
            }

        }

        // in this function we are looking for queens above current cordinated that can cut this queen
        private bool isSafeToPlace(int[,] board, int row, int col)
        {
            for (int i = row - 1, j = col; i >= 0; i--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col + 1; i >= 0 && j < board.GetLength(0); i--, j++)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }





    }