
namespace Practice5_2.Servants
{
    internal class Servant
    {
        private int _cooling;
        public string Character { get; set; }
        public int Hp { get; set; }
        public int Charge { get; set; }
        public int Atk { get; set; }
        public int Speed { get; set; }
        public int Cooling 
        {   get => _cooling;
            set => _cooling = (value > 0) ? value : 0;
        }

        
        protected Servant(string Character, int Hp, int Charge, int Atk, int Speed)
        {
            this.Character = Character;
            this.Hp = Hp;
            this.Charge = Charge;
            this.Atk = Atk;
            this.Speed = Speed;
            this.Cooling = 2;
        }

        public virtual void UseSkill()
        {
            if (Cooling > 0)
            {
                throw new Exception($"技能冷卻中(剩餘回合:{Cooling})");
            }
            Cooling = 3;
        }

        public virtual void UseUltimate(params Servant[] targets)
        {
            if (Charge < 100) throw new Exception("充能不足，無法施放寶具!");
            Charge -= 100;
        }

        // Normal Attack: return If it is critical attack
        public virtual bool NormalAttack(Servant target)
        {
            bool critical = IsCriticalHit();
            target.Hp -= Atk * (critical ? 2 : 1);
            IncreaseCharge(critical);
            return critical;
        }

        private bool IsCriticalHit()
        {
            return new Random().Next(2) == 1;
        }

        private void IncreaseCharge(bool critical)
        {
            if (critical)
            {
                Charge += 30;
            } else
            {
                Charge += new Random().Next(20, 26);
            }
        }
    }
}
