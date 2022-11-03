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
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

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
        //pengurutan
        static public void SortMerge(int[] numbers, int left, int right)
        { //rumus mergesort
            int mid;
            if( right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        //masukkan element array

    }
}