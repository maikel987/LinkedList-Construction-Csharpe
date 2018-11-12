using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Sorts
    {

        public static void MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        static void MergeSort(int[] arr, int leftInd, int rightInd)
        {
            if(leftInd < rightInd)
            {
                int midInd = (leftInd + rightInd) / 2;
                MergeSort(arr, leftInd, midInd);
                MergeSort(arr, midInd + 1, rightInd);
                Merge(arr, leftInd, midInd, midInd + 1, rightInd);               
            }
        }

        private static void Merge(int[] arr, int left1, int right1, int left2, int right2)
        {
            int[] tmpArr = new int[right2 - left1 + 1];
            int i = left1, j = left2, ind = 0;

            while(i<=right1 && j<=right2)
            {
                if (arr[i] < arr[j])
                    tmpArr[ind] = arr[i++];
                else
                    tmpArr[ind] = arr[j++];
                ind++;
            }
           
            while (i <= right1)
            {
                tmpArr[ind] = arr[i++];
                ind++;
            }

            while (j <= right2)
            {
                tmpArr[ind] = arr[j++];
                ind++;
            }

            for (int k = 0; k < tmpArr.Length; k++, left1++)
            {
                arr[left1] = tmpArr[k];
            }
        }
    }
}
