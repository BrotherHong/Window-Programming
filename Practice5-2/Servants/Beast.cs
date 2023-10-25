
namespace Practice5_2.Servants
{
    internal class Beast : Servant
    {

        public Beast() : base("Beast", 500, 0, 2, 3)
        {
        }

        public override bool NormalAttack(Servant target)
        {
            target.Hp -= Atk;
            return false;
        }

        public override void UseSkill()
        {
            base.UseSkill();
            Atk += 2;
        }

        public override void UseUltimate(params Servant[] targets)
        {
            base.UseUltimate(targets);
            foreach (Servant target in targets)
            {
                target.Hp -= Atk * 2;
            }
        }
    }
}
