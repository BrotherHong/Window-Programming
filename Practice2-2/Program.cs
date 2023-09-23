using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2
{
    internal class Program
    {
        private static bool[,] ghost, reveal;
        private static int M, N;
        private static int ghostAmount;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            // Variables
            string[] split;
            int remainSlots;

            // Inputs
            Console.WriteLine("設定遊戲參數");

            Console.Write("輸入空間的大小: ");
            string sizeInput = Console.ReadLine()!;
            split = sizeInput.Split(',');

            Debug.Assert(split.Length == 2);

            M = int.Parse(split[0]);
            N = int.Parse(split[1]);
            ghost = new bool[M, N];
            reveal = new bool[M, N];

            Debug.Assert(1 <= M && M <= 26 && 1 <= N && N <= 26);

            Console.Write("輸入鬼的數量: ");
            ghostAmount = int.Parse(Console.ReadLine()!);

            // Check Ghost amount is valid
            if (!CheckGhostAmount())
            {
                Console.WriteLine("遊戲參數錯誤!");
                Console.Read();
                return;
            }
            remainSlots = M * N - ghostAmount;

            // Clear console
            Console.Clear();

            // Game start
            int round = 1;
            while (true)
            {
                // Print the slots
                PrintSlots();

                // Input the slot that player wants to reveal
                int r, c;
                while (true)
                {
                    Console.Write("輸入要查看的位置: ");
                    string input = Console.ReadLine()!;
                    split = input.Split(",");
                    r = int.Parse(split[0]);
                    c = split[1][0] - 'A';

                    // Check input is valid
                    if (!CheckRevealPosition(r, c))
                    {
                        Console.WriteLine("無效的輸入，請再試一次");
                        continue;
                    }
                    break;
                }

                // If first round, generate the ghosts but can't generate on revealed slot
                if (round == 1)
                {
                    reveal[r, c] = true;
                    GenerateGhosts();
                }

                // Check the slot is ghost or nothing
                if (GetSlotNumber(r, c) == -1) // if it's ghost
                {
                    // Reveal all slots
                    Console.Clear();
                    RevealAllSlots();
                    PrintSlots();
                    Console.WriteLine("遊戲結束! 你被鬼抓到了");
                    Console.Read();
                    return;
                } else
                {
                    reveal[r, c] = true;
                    remainSlots--;
                }

                // If all "nothing" slot were revealed, print win message and end the game
                if (remainSlots == 0)
                {
                    Console.Clear();
                    RevealAllSlots();
                    PrintSlots();
                    Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
                    break;
                }

                // Clear the console and go to next round
                Console.Clear();
                round++;
            }

            Console.Read();
        }

        private static bool CheckGhostAmount()
        {
            return ghostAmount > 0 && M*N > ghostAmount;
        }

        private static void PrintSlots()
        {
            StringBuilder sb = new StringBuilder();
            
            // First Line
            sb.Append("   ");
            for (int j = 0; j < N; j++)
            {
                sb.Append($"{(char)('A' + j)} ");
            }
            sb.AppendLine();

            // Each Row
            for (int i = 0; i < M; i++)
            {
                sb.Append(string.Format("{0,-2} ", i));
                for (int j = 0; j < M; j++)
                {
                    sb.Append(string.Format("{0} ", reveal[i, j] ? (ghost[i, j] ? 'X' : (char)(GetSlotNumber(i, j)+'0')) : '-'));
                }
                sb.AppendLine();
            }

            // Output result
            Console.Write(sb.ToString());
        }

        private static bool CheckRevealPosition(int r, int c)
        {
            if (r < 0 || r >= M) return false;
            if (c < 0 || c >= N) return false;
            if (reveal[r, c]) return false;
            return true;
        }

        private static int GetSlotNumber(int r, int c)
        {
            if (ghost[r, c]) return -1;

            int count = 0;
            for (int i = Math.Max(r-1, 0); i <= Math.Min(M-1, r+1); i++)
            {
                for (int j = Math.Max(c-1, 0); j <= Math.Min(N-1, c+1); j++)
                {
                    if (i == r && j == c) continue;
                    if (ghost[i, j]) count++;
                }
            }

            return count;
        }

        private static void GenerateGhosts()
        {
            int done = 0;
            int r, c;
            while (done < ghostAmount)
            {
                // choose a slot randomly
                r = random.Next(0, M);
                c = random.Next(0, N);

                // check the ghost can be placed at that slot
                if (ghost[r, c] || reveal[r, c])
                {
                    continue;
                }

                // set the ghost
                ghost[r, c] = true;
                done++;
            }
        }

        private static void RevealAllSlots()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    reveal[i, j] = true;
                }
            }
        }
    }
}
