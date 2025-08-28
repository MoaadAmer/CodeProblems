
namespace CodeProblems.Fundamentals.Sorting
{
    public class Sorting
    {

        //Runtime O(n^2)
        //Space O(1)
        public void BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                bool swap = false;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                {
                    return;
                }
            }
        }

        //Runtime O(n^2)
        //Space O(1)
        public void InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        //Runtime O(n^2)
        //Space O(1)
        public void SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = nums[i];
                    nums[i] = nums[minIndex];
                    nums[minIndex] = temp;
                }
            }
        }

        //Runtime O(n log n)
        //Space O(n)
        public int[] MergeSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }

            int leftSideLength = nums.Length / 2;
            int[] leftSide = new int[leftSideLength];
            int l = 0;
            for (; l < leftSideLength; l++)
            {
                leftSide[l] = nums[l];
            }

            int rightSideLength = nums.Length - (nums.Length / 2);
            int[] rightSide = new int[rightSideLength];

            int r = 0;
            for (; r < rightSideLength; r++)
            {
                rightSide[r] = nums[l + r];
            }
            leftSide = MergeSort(leftSide);
            rightSide = MergeSort(rightSide);

            leftSideLength = leftSide.Length;
            rightSideLength = rightSide.Length;
            int[] sortedArray = new int[leftSideLength + rightSideLength];

            l = 0;
            r = 0;
            while (l < leftSideLength && r < rightSideLength)
            {
                if (leftSide[l] < rightSide[r])
                {
                    sortedArray[l + r] = leftSide[l];
                    l++;
                }
                else
                {
                    sortedArray[l + r] = rightSide[r];
                    r++;
                }
            }

            while (l < leftSideLength)
            {
                sortedArray[l + r] = leftSide[l];
                l++;
            }

            while (r < rightSideLength)
            {
                sortedArray[l + r] = rightSide[r];
                r++;
            }

            return sortedArray;
        }
        
        //Runtime O(n log n)
        //Space O(n)
        public int[] QuickSort(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }
            int[] pivot = [nums[nums.Length - 1]];
            int leftSize = 0;
            int rightSize = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] <= pivot[0])
                {
                    leftSize++;
                }
                else
                {
                    rightSize++;
                }
            }
            int[] leftSide = new int[leftSize];
            int[] rightSide = new int[rightSize];
            int l = 0;
            int r = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] <= pivot[0])
                {
                    leftSide[l++] = nums[i];
                }
                else
                {
                    rightSide[r++] = nums[i];
                }
            }
            leftSide = QuickSort(leftSide);
            rightSide = QuickSort(rightSide);

            int[] sortedArray = new int[leftSide.Length + rightSide.Length + 1];

            l = 0;
            while (l < leftSide.Length)
            {
                sortedArray[l] = leftSide[l];
                l++;
            }
            r = 0;
            sortedArray[l + r] = pivot[0];
            while (r < rightSide.Length)
            {
                sortedArray[l + r + 1] = rightSide[r];
                r++;
            }
            return sortedArray;
        }

        //Runtime O(n +k)
        //Space O(k)
        public void CountingSort(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }
            int j = 0;
            for (int i = 1; i < count.Length; i++)
            {
                while (count[i] != 0)
                {
                    nums[j] = i;
                    count[i] -= 1;
                    j++;
                }
            }
        }
    }
}
