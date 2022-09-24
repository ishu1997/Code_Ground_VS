// See https://aka.ms/new-console-template for more information
            Console.WriteLine("Practice session");

            // Recursion_Practice recursion = new Recursion_Practice();
            // var x = recursion.allIndices(new int[] {2,3,4,5,3,6,1},3);
            //var x = recursion.GETAllSubsequence("bc");
            //var x = recursion.GetKeyPadCombination("563");
            //var x = recursion.getAllStairCasePath(3);
            //var y = recursion.getAllMazePaths(1, 1, 2, 3);
            //var x = recursion.getAllMazePathsSTRING(1, 1, 2, 3);
            //var x = recursion.getAllMazePathswithJumpSTRING(1,1,3,3);
            // foreach (var i in x)
            // {
            //    Console.WriteLine(i);
            // }

            // from here on the printing statements not returning the output in a list

            //recursion.PrintSS("abc", "");
            //recursion.PrintKeyPad("53", "");
            //recursion.PrintStairpath(3, "");
            //recursion.PrintMazePaths(8, 1, 1, 1, "");
            //recursion.PrintMazepathsWithJumps(3, 3, 1, 1, "");
            //recursion.PrintPermutation("abc", "");
            //recursion.PrintEncodings("128", "");

            //int[,] maze = new int[,] 
            //{ {0,1,0,0,0,0,0},
            //  {0,1,0,1,1,1,0},
            //  {0,0,0,0,0,0,0},
            //  {1,0,1,1,0,1,1},
            //  {1,0,1,1,0,1,1},
            //  {1,0,0,0,0,0,0}
            //};
            //bool[,] visited = new bool[maze.GetLength(0), maze.GetLength(1)];
            //recursion.Floodfill(maze, 0, 0, visited, "");


            //int[] arr = new int[] { 10,20,30,40,50};
            //recursion.TargetSubset(arr, 70, 0, 0, "");

            //recursion.NqueensOnBoard(new int[4, 4], 0, "");


            Sorting sort = new Sorting();
            //var x = sort._bubble_sort(new int[] {1,2,3,4,5,6,0 });
            var x = sort._selection_sort(new int[] { 1,  3, 5, 6, 4, 2, 0 });

            foreach (var i in x)
            {
                Console.WriteLine(i);
            }
       
