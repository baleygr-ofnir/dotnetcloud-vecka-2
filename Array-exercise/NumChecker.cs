namespace Array_exercise;

class NumChecker()
{
    public int[] Nums = [5];
    public int Average;
    public int Highest;
    public NumChecker(int first, int second, int third, int fourth, int fifth) : this()
    {
        Nums = [ValidInput(), second, third, fourth, fifth];
        Average = (Nums[0] + Nums[1] + Nums[2] + Nums[3] + Nums[4]) / Nums.Length;
        Highest = Nums.Max();
    }

    public int[] ReverseNums(int[] nums)
    {
        Array.Reverse(nums);
        return nums;
    }
    public bool SearchArray(int num)
    {
        return Nums.Contains(num);
    }

    private int ValidInput()
    {
        bool validInt = false;
        int num;
        do
        {
            if (!validInt)
            {
                Console.Write("\nEnter valid integer: ");
            }
            validInt = int.TryParse(Console.ReadLine(), out num);
        } while (!validInt);

        return num;
    }
}