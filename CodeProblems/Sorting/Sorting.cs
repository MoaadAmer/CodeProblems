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
    }

}
