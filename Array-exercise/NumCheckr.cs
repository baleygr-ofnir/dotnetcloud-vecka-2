namespace Array_exercise;

class NumCheckr()
{
    public int[] Nums = [5];
    public int[] ReverseNums = [5];
    public int Average;
    public int Highest;
    public NumCheckr(int first, int second, int third, int fourth, int fifth) : this()
    {
        Nums = [first, second, third, fourth, fifth];
        Average = (Nums[0] + Nums[1] + Nums[2] + Nums[3] + Nums[4]) / Nums.Length;
        Highest = Nums.Max();
        ReverseNums = [first, second, third, fourth, fifth];
        Array.Reverse(ReverseNums);
    }
    public void SearchArray(int num)
    {
        Console.WriteLine(Nums.Contains(num) ? $"Array contains {num}" : $"Array does not contain {num}");
    }
}