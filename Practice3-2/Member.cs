using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    internal class Member
    {
        private int _level;

        public string Name { get; private set; }
        public string Department { get; private set; }
        public string Id { get; private set; }
        public string Level { get; private set; }
        public string Title { get; set; }

        public Member(string Name, string Department, string Id)
        {
            _level = 1;
            this.Name = Name;
            this.Department = Department;
            this.Id = Id;
            this.Level = "萌新社員";
            this.Title = "無";
        }

        public void Upgrade()
        {
            if (!Upgradable()) return;
            _level++;
            switch (_level)
            {
                case 2:
                    this.Level = "資深社員";
                    break;
                case 3:
                    this.Level = "永久社員";
                    break;
            }
        }

        public bool Upgradable()
        {
            return _level < 3;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Member) return false;
            Member other = (obj as Member)!;
            return Name == other.Name && Department == other.Department && Id == other.Id; ;
        }

        public override int GetHashCode()
        {
            return new { Name, Department, Id }.GetHashCode();
        }
    }
}
