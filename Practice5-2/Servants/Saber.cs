
namespace Practice5_2.Servants
{
    internal class Saber : Servant
    {
        public Saber() : base("Saber", 100, 0, 3, 1)
        {
        }

        public override void UseSkill()
        {
            base.UseSkill();
            Atk *= 2;
        }

        public override void UseUltimate(params Servant[] targets)
        {
            base.UseUltimate(targets);
            foreach (Servant target in targets)
            {
                target.Hp -= Atk + 25;
                Hp += 5;
            }
        }
    }
}
