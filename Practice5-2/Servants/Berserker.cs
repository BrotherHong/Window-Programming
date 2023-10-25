
namespace Practice5_2.Servants
{
    internal class Berserker : Servant
    {
        public Berserker() : base("Berserker", 100, 0, 4, 4)
        {
        }

        public override void UseSkill()
        {
            base.UseSkill();
            Atk *= 2;
            Hp = Hp - (Hp / 2);
        }

        public override void UseUltimate(params Servant[] targets)
        {
            base.UseUltimate(targets);
            foreach(Servant target in targets)
            {
                target.Hp -= Atk + 50;
            }
        }
    }
}
