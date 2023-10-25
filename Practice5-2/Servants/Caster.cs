
namespace Practice5_2.Servants
{
    internal class Caster : Servant
    {
        public Caster() : base("Caster", 100, 0, 2, 2)
        {
        }

        public override void UseSkill()
        {
            base.UseSkill();
            Hp += 100 / 2;
        }

        public override void UseUltimate(params Servant[] targets)
        {
            base.UseUltimate(targets);
            foreach (Servant target in targets)
            {
                target.Atk += 1;
                target.Hp += 10;
            }
        }
    }
}
