using System.Reflection.Metadata.Ecma335;

namespace SumOfTwo
{
    /// <summary>
    /// 
    /// This time you have to write a method that will take two arguments: a list of integers nums and an integer `SumToFind`
    /// And it returns the number of possible UNIQUE pares made from this list where the sum equals to `SumToFind`
    /// 
    /// Example:
    /// SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2)
    /// It should return: 1
    /// Explanation: there is only one pair sum of witch is equal to 2 (1,1)
    /// 
    /// ATTENTION:
    /// The main trick of this exercise is that its time complexity should be linear
    /// That means you should NOT have any double/triple loops inside or deep recursion
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2)); // Expected = 1
            Console.WriteLine(SumOfTwo([1, 1, 1, 1, 2, 3, 4, 5, 2], 2)); // Expected = 2
            Console.WriteLine(SumOfTwo([1, 1, 1, 1, 2, 3, 4, 5, 2], 5)); // Expected = 2
        }
        public static int SumOfTwo(int[] nums, int sumToFind)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();
            int result = 0;

            foreach (int value in nums)
            {
                if (dic.ContainsKey(sumToFind - value) && dic[sumToFind - value] > 0)
                {
                    dic[sumToFind - value]--;
                    result ++;
                    continue;
                }
                if (dic.ContainsKey(value))
                {
                    dic[value]++;
                } else
                {
                    dic.Add(value, 1);
                }
            }
            return result;
        }
    }
}