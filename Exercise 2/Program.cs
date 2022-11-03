using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSort
    { //method mergesort
      static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[27];
            int 1, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            numbers = (right - left + 1);

            //perulangan
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for(i = 0; i < 1; i++)
            {
                numbers[right] = temp[right];
                    right--;
            }

        }

    }
}