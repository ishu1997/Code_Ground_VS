public class Sorting
    {

        public int[] _bubble_sort(int[] unSorted)
        {

            // for every iteration we make sure that largest element shifts to the end
            // so after every iteration larget among the unsettled elements will move to
            // the place before the earlier largest place

            if (unSorted.Length <= 1)
            {
                return unSorted;
            }

            for (int i = 0; i < unSorted.Length; i++)
            {
                for (int j = 1; j < unSorted.Length - i; j++)
                {
                    if (unSorted[j - 1] > unSorted[j])
                    {
                        var temp = unSorted[j - 1];
                        unSorted[j - 1] = unSorted[j];
                        unSorted[j] = temp;
                    }
                }
            }

            return unSorted;
        }

        public int[] _selection_sort(int[] unSorted)
        {
            if (unSorted.Length <= 1)
            {
                return unSorted;
            }

            // we have to find the smallest in every iteration
            // replace this minimum with the element with the cursor
            // with every iteration the cursor moves to the right and number of comparison reduces

            for(int cursor = 0; cursor < unSorted.Length - 1; cursor++)
            {
                int min = cursor;
                for(int iterator=cursor+1;iterator< unSorted.Length; iterator++)
                {
                    if(unSorted[min] > unSorted[iterator])
                    {
                        min = iterator;
                    }
                }

                if (unSorted[cursor] > unSorted[min])
                {
                    var temp = unSorted[cursor];
                    unSorted[cursor] = unSorted[min];
                    unSorted[min] = temp;
                }

            }
            // return the sorted array
            //check for vs
            return unSorted;
        }

        // jitna array ban gaya h utna sorted hona chahiye
        public int[] _insertion_sort(int[] unSorted){

            for(int i=1;i<unSorted.Length;i++){                

               for(int j=i;j>0;j--){

                    if(unSorted[j]<unSorted[j-1]){
                    var temp = unSorted[j-1];
                    unSorted[j-1] = unSorted[j];
                    unSorted[j] = temp;
                    }

               }

            }




            return unSorted;
        }

    }