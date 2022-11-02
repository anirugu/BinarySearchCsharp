namespace BinarySearchCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Program program = new Program();
            int result = program.Search(new int[] { 5 }, -5);
        }

        public int Search(int[] nums, int target)
        {
            bool found = false;
            int index = -1;
            Parallel.For(0, nums.Length, (i) =>
            {
                if (found)
                    return;
                if (nums[i] == target)
                {
                    index = i;
                    return;
                }
            });
            return index;
        }
    }
}

/*
 This problem can be solved with mutliple way.

1. Write a for loop
2. Write a do While loop.
3. Write a parallel loop
4. Multi pointer loop
 */