
namespace Practice6_2
{
    public partial class Form1
    {
        private static readonly List<int[]>[] displayPosition =
        {
            // 0
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 0), NewPair(1, 4),
                NewPair(2, 0), NewPair(2, 4),
                NewPair(4, 0), NewPair(4, 4),
                NewPair(5, 0), NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 1
            new List<int[]> {
                NewPair(1, 4),
                NewPair(2, 4),
                NewPair(4, 4),
                NewPair(5, 4),
            },
            // 2
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 4),
                NewPair(2, 4),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 0),
                NewPair(5, 0),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 3
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 4),
                NewPair(2, 4),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 4),
                NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 4
            new List<int[]> {
                NewPair(1, 0), NewPair(1, 4),
                NewPair(2, 0), NewPair(2, 4),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 4),
                NewPair(5, 4),
            },
            // 5
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 0),
                NewPair(2, 0),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 4),
                NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 6
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 0),
                NewPair(2, 0),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 0), NewPair(4, 4),
                NewPair(5, 0), NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 7
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 4),
                NewPair(2, 4),
                NewPair(4, 4),
                NewPair(5, 4),
            },
            // 8
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 0), NewPair(1, 4),
                NewPair(2, 0), NewPair(2, 4),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 0), NewPair(4, 4),
                NewPair(5, 0), NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
            // 9
            new List<int[]> {
                NewPair(0, 1), NewPair(0, 2), NewPair(0, 3),
                NewPair(1, 0), NewPair(1, 4),
                NewPair(2, 0), NewPair(2, 4),
                NewPair(3, 1), NewPair(3, 2), NewPair(3, 3),
                NewPair(4, 4),
                NewPair(5, 4),
                NewPair(6, 1), NewPair(6, 2), NewPair(6, 3)
            },
        };

        private static int[] NewPair(int first, int second)
        {
            return new int[2] { first, second };
        }
    }
}