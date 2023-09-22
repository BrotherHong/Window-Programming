using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            GradeCalculator calculator = new GradeCalculator();
            bool exit = false;

            while (true)
            {
                PrintMenu();

                Console.Write("輸入要執行的指令操作: ");
                string cmdInput = Console.ReadLine();

                try
                {
                    CheckCommandFormat(cmdInput);

                    string[] param = cmdInput.Split(' ');
                    string cmd = param[0];
                    string subjectCode;
                    int grade;
                    int credit;

                    switch (cmd[0])
                    {
                        case 'c': // create
                            subjectCode = param[1];
                            grade = int.Parse(param[2]);
                            credit = int.Parse(param[3]);
                            CheckGradeRange(grade);
                            CheckCreditRange(credit);
                            calculator.AddSubject(new Subject(subjectCode, grade, credit));
                            Console.WriteLine("科目已新增");
                            break;
                        case 'd': // delete
                            subjectCode = param[1];
                            calculator.RemoveSubject(subjectCode);
                            Console.WriteLine("科目已刪除");
                            break;
                        case 'u': // update
                            subjectCode = param[1];
                            grade = int.Parse(param[2]);
                            credit = int.Parse(param[3]);
                            CheckGradeRange(grade);
                            CheckCreditRange(credit);
                            calculator.UpdateSubject(new Subject(subjectCode, grade, credit));
                            Console.WriteLine("科目已更新");
                            break;
                        case 'p': // print
                            Console.WriteLine();
                            Console.Write(calculator.SortAndPrintGradeAsString());
                            break;
                        case 'e': // exit
                            exit = true;
                            Console.WriteLine("離開成績計算機");
                            break;
                    }
                    Console.WriteLine();
                    if (exit) break;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }

            Console.Read();
        }

        static void PrintMenu()
        {
            Console.WriteLine("## 成績計算機 ##");
            Console.WriteLine("1. 新增科目(create)");
            Console.WriteLine("2. 刪除科目(delete)");
            Console.WriteLine("3. 更新科目(update)");
            Console.WriteLine("4. 列印成績單(print)");
            Console.WriteLine("5. 退出選單(exit)");
        }

        static void CheckCommandFormat(string cmd)
        {
            string[] data = cmd.Split(' ');

            if (data.Length == 0 ) throw new Exception("指令格式不符! 請重新輸入!");

            string head = data[0];

            if (head == "create")
            {
                if (data.Length != 4) throw new Exception("指令格式不符! 請重新輸入!");
            } else if (head == "delete")
            {
                if (data.Length != 2) throw new Exception("指令格式不符! 請重新輸入!");
            } else if (head == "update")
            {
                if (data.Length != 4) throw new Exception("指令格式不符! 請重新輸入!");

            } else if (head == "print")
            {
                if (data.Length != 1) throw new Exception("指令格式不符! 請重新輸入!");
            } else if (head == "exit")
            {
                if (data.Length != 1) throw new Exception("指令格式不符! 請重新輸入!");
            } else
            {
                throw new Exception("指令格式不符! 請重新輸入!");
            }
        }

        static void CheckGradeRange(int grade)
        {
            if (0 <= grade && grade <= 100) return;
            throw new Exception("成績分數異常! 請重新輸入!");
        }

        static void CheckCreditRange(int credit)
        {
            if (0 <= credit && credit <= 10) return;
            throw new Exception("學分數異常! 請重新輸入!");
        }
    }
}
