namespace CardAbstract
{
    public abstract class Card
    {
        public abstract int Number { get; set; }
        public abstract string HolderName { get; set; }
        public abstract float Money { get; set; }

        public abstract float pay(float cost);
        public abstract float SetAmount(float amount);
        public abstract float AddWithBonus(float amount);
    }
}