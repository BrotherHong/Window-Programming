using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    internal class Program
    {
        private static readonly string[] cmdList =
        {
            "register", "search", "entitle", "check", "help", "exit"
        };
        private static readonly int[] cmdArgsRequired =
        {
            3, 2, 4, 0, 0, 0
        };
        private static readonly Dictionary<string, SearchType> tagMap = new Dictionary<string, SearchType>()
        {
            { "name", SearchType.NAME },
            { "department", SearchType.DEPARTMENT },
            { "id", SearchType.ID },
            { "level", SearchType.LEVEL },
            { "title", SearchType.TITLE },
        };

        public static void Main(string[] args)
        {
            MemberDataSystem system = new MemberDataSystem();

            Console.WriteLine("\t\t\t>> 歡迎使用社員資料登記系統 <<");
            Console.WriteLine("\t\t\t>> 以下是所有可用的功能指令 <<");
            PrintHelp();

            while (true)
            {
                try
                {
                    Console.Write("輸入指令>> ");
                    string input = Console.ReadLine()!;
                    input = input.Trim();
                    if (input == "") continue;

                    string[] cutted_input = input.Split(' ');
                    CheckInput(cutted_input);

                    string cmd = cutted_input[0];

                    if (cmd == "register")
                    {
                        string name = cutted_input[1];
                        string department = cutted_input[2];
                        string id = cutted_input[3];

                        string resp = system.Register(new Member(name, department, id));
                        Console.WriteLine(resp);
                    } else if (cmd == "search")
                    {
                        string tagStr = cutted_input[1].ToLower();
                        string target = cutted_input[2];

                        if (!tagMap.ContainsKey(tagStr))
                        {
                            throw new Exception("無效的tag");
                        }

                        SearchType tag = tagMap[tagStr];
                        List<Member> resp = system.Search(tag, target);

                        if (resp.Count > 0)
                        {
                            Console.WriteLine();
                            PrintMembers(resp);
                            Console.WriteLine();
                        } else
                        {
                            string msg = "";
                            switch (tag)
                            {
                                case SearchType.NAME: msg = "找不到這個人ㄟ"; break;
                                case SearchType.DEPARTMENT: msg = "找不到這個系的人ㄟ"; break;
                                case SearchType.ID: msg = "找不到這個學號的人ㄟ"; break;
                                case SearchType.LEVEL: msg = "找不到這個等級的人ㄟ"; break;
                                case SearchType.TITLE: msg = "找不到這個職務的人ㄟ"; break;
                            }
                            throw new Exception(msg);
                        }


                    } else if (cmd == "entitle")
                    {
                        string name = cutted_input[1];
                        string department = cutted_input[2];
                        string id = cutted_input[3];
                        string title = cutted_input[4];

                        string resp = system.Entitle(new Member(name, department, id), title);
                        Console.WriteLine("\t" + resp);
                    } else if (cmd == "check")
                    {
                        List<Member> members = system.GetMembers();
                        Console.WriteLine("----------------------------------------------------------------");
                        PrintMembers(members);
                        Console.WriteLine("----------------------------------------------------------------");
                    } else if (cmd == "help")
                    {
                        PrintHelp();
                    } else if (cmd == "exit")
                    {
                        Console.WriteLine("已離開系統...");
                        break;
                    }

                } catch (Exception e)
                {
                    Console.WriteLine("\t" + e.Message);
                }
            }

            Console.Read();
        }

        private static void PrintHelp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------------------------------------------");
            sb.AppendLine("新增社員資訊:\tregister\tname\tdepartment\tID");
            sb.AppendLine("以特定屬性查詢:\tsearch\t\ttag\twant_search_string");
            sb.AppendLine("授予社員職位:\tentitle\t\tname\tdepartment\tID\tthat_title");
            sb.AppendLine("所有社員列表:\tcheck");
            sb.AppendLine("指令格式列表:\thelp");
            sb.AppendLine("離開此程式:\texit");
            sb.AppendLine("----------------------------------------------------------------------------");
            Console.Write(sb.ToString());
        }

        private static void CheckInput(string[] cutted)
        {
            Debug.Assert(cutted.Length > 0);
            string cmd = cutted[0];
            for (int i = 0; i < cmdList.Length; i++)
            {
                if (cmd == cmdList[i])
                {
                    if (cutted.Length-1 != cmdArgsRequired[i])
                    {
                        throw new Exception("參數數量有誤!");
                    }
                    return;
                }
            }
            throw new Exception("不存在這個功能，有疑慮請打help");
        }

        private static void PrintMembers(List<Member> members)
        {
            StringBuilder sb = new StringBuilder();
            if (members.Count == 0)
            {
                sb.AppendLine("尚無社員資料");
            } else
            {
                foreach (Member member in members)
                {
                    sb.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", 
                        member.Name, member.Department, member.Id, member.Level, member.Title));
                }
            }
            Console.Write(sb.ToString());
        }
    }
}
