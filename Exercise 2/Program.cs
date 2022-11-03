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
            int MA, eol, num, pos;
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
            for(MA = 0; MA < num; MA++)
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
        static void Main(string[] args)
        {
            Console.Write("\nprogram for shorting a numeric array using merge sorting");
            Console.Write("\n\nEnter number of elements:");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[27];
            for (int MA = 0; MA < max; MA++)
            {
                //menampilkan element yg diinputa
                Console.Write("\nEnter [" + (MA + 1).ToString() + "] Element : ");
                numbers[MA] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array:");
            Console.Write("\n");
            for(int i = 0; i < max; i++)
            {
                Console.Write(numbers[i] + " ");
                Console.Write("\n");
            }
            //MENAMPILKAN HASIL
            Console.WriteLine("mergesort by recursive method");
            SortMerge(numbers, 0, max - 1);
            for (int MA = 0; MA < max; MA++)
                Console.WriteLine(numbers[MA]);
            Console.ReadLine();
        }
    } 
   
}

