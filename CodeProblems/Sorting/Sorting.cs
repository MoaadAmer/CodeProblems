namespace CodeProblems.Sorting
{
    public class Sorting
    {

        //Runtime O(n^2)
        //Spacetime O(1)
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
        //Spacetime O(1)
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
        //Spacetime O(1)
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
    }

}
