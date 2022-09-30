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

        for (int cursor = 0; cursor < unSorted.Length - 1; cursor++)
        {
            int min = cursor;
            for (int iterator = cursor + 1; iterator < unSorted.Length; iterator++)
            {
                if (unSorted[min] > unSorted[iterator])
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
    public int[] _insertion_sort(int[] unSorted)
    {

        for (int i = 1; i < unSorted.Length; i++)
        {

            for (int j = i; j > 0; j--)
            {

                if (unSorted[j] < unSorted[j - 1])
                {
                    var temp = unSorted[j - 1];
                    unSorted[j - 1] = unSorted[j];
                    unSorted[j] = temp;
                }

            }

        }
        return unSorted;
    }

    public int[] _merge_Two_Sorted_Arrays(int[] a1, int[] a2)
    {

        int[] result = new int[a1.Length + a2.Length];

        int i = 0, j = 0, count = 0;

        while (i < a1.Length && j < a2.Length)
        {
            if (a1[i] < a2[j])
            {
                result[count] = a1[i];
                i++;
            }
            else
            {
                result[count] = a2[j];
                j++;
            }

            count++;
        }


        while (i < a1.Length)
        {
            result[count] = a1[i];
            i++;
            count++;
        }

        while (j < a2.Length)
        {
            result[count] = a2[j];
            j++;
            count++;
        }


        return result;
    }

    //slight variation while using list instead of arrays
    // public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    // {

    //     ListNode result = new ListNode();
    //     var tail = result;

    //     while (list1 != null && list2 != null)
    //     {
    //         if (list1.val > list2.val)
    //         {
    //             tail.next = list2;
    //             list2 = list2.next;
    //         }
    //         else
    //         {
    //             tail.next = list1;
    //             list1 = list1.next;
    //         }

    //         tail = tail.next;
    //     }

    //     if (list1 == null && list2 != null)
    //     {
    //         tail.next = list2;
    //     }

    //     if (list2 == null && list1 != null)
    //     {
    //         tail.next = list1;
    //     }

    //     return result.next;

    // }



}