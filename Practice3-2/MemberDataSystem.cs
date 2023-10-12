using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    internal enum SearchType
    {
        NAME, DEPARTMENT, ID, LEVEL, TITLE,
    }

    internal class MemberDataSystem
    {
        private List<Member> _members;

        public MemberDataSystem()
        {
            _members = new List<Member>();
        }

        public List<Member> GetMembers()
        {
            return _members;
        }

        public string Register(Member member)
        {
            if (!HasMember(member))
            {
                _members.Add(member);
                return "歡迎新社員!!";
            } else
            {
                member = FindMember(member)!;
                if (!member.Upgradable())
                {
                    return "已經是永久社員了喔";
                }
                member.Upgrade();
                return "已晉升為" + member.Level;
            }
        }

        public List<Member> Search(SearchType type, string target)
        {
            return type switch
            {
                SearchType.NAME => _members.FindAll(m => m.Name == target),
                SearchType.DEPARTMENT => _members.FindAll(m => m.Department == target),
                SearchType.ID => _members.FindAll(m => m.Id == target),
                SearchType.LEVEL => _members.FindAll(m => m.Level == target),
                SearchType.TITLE => _members.FindAll(m => m.Title == target),
                _ => new List<Member>(),
            };
        }

        public string Entitle(Member member, string title)
        {
            if (!HasMember(member))
            {
                return "找不到這個人ㄟ";
            }
            if (title.Contains("社長"))
            {
                return "我們的社長只有阿明一個人，你不要想篡位!";
            }
            member = FindMember(member)!;
            member.Title = title;
            return string.Format("{0}已晉升為{1}!", member.Name, member.Title);
        }

        public bool HasMember(Member member)
        {
            return FindMember(member) != null;
        }

        private Member? FindMember(Member member)
        {
            return _members.FindLast(m => m.Equals(member));
        }

    }
}
