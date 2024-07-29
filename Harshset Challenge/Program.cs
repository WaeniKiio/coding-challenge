

public class UniqueAbsoluteValues
{
    public static int UniqueAbsValues(int[] A)
    {
        HashSet<int> abNumbers = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            abNumbers.Add(Math.Abs(A[i]));
        }

        return abNumbers.Count;
    }

    public static void Main(string[] args)
    {
        int[] A = { -1, 1, 2, -2, 3 };
        Console.WriteLine(UniqueAbsValues(A)); 
    }
}


public class Solution
{
    public int solution(int X, int Y, int D)
    {
        int distance = Y - X;
        return (int)Math.Ceiling((double)distance / D);
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(10, 85, 30)); // Output: 3
    }
}




