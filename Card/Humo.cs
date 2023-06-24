using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardAbstract;
namespace Uzcard
{
    public class humo : Card
    {
        public override int Number { get; set; }
        public override string HolderName { get; set; }
        public override float Money { get; set; }
        public float cost { get; set; }
       // public humo(float Cost) { cost = Cost; }
        public override float pay(float cost)
        {

            if (PulKopmi(Money, cost) == true)
            {
                Money = Money - cost;
                return Money;
            }
            else
                return Money;
        }
        private bool PulKopmi(float Money,float cost){
            if(Money-cost<0 || cost > 50000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override float SetAmount(float amount)
        {
            return 0;
        }
        public override float AddWithBonus(float amount)
        {
            return 0;
        }
    }
}
