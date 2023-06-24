using CardAbstract;
namespace Uzcard
{
    public class uzcard : Card
    {
        private float Bonus = 5;
        public override int Number { get; set; }
        public override string HolderName { get; set; }
        public override float Money { get; set; }
        public float amount { get; set; }

        public uzcard(float money) { Money = money; }
        public override float pay(float cost)
        {
            return 0;
        }
        public override float SetAmount(float amount)
        {
            Money = Money + amount;
            return Money;
        }
        public override float AddWithBonus(float amount)
        {
            Money = Money + amount + Bonus;
            return Money;
        }
    }
}