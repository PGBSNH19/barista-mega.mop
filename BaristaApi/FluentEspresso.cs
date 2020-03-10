using System;
using System.Collections.Generic;

namespace BaristaApi
{
    public class FluentEspresso : IFluentEspresso
    {
        private List<string> ingrediens;
        private int amountInCup;

        public FluentEspresso()
        {
            ingrediens = new List<string>();
        }


        public Beverage ToBeverage()
        {
            if (ingrediens.Contains("espresso") && 
                    ingrediens.Contains("milk"))
            {
                return new Latte();
            }


            if (ingrediens.Contains("espresso"))
            {
                return new Espresso();
            }
            return null;
        }

        public IFluentEspresso AddEspresso(int amount)
        {
            ingrediens.Add("espresso");
            amountInCup += amount;
            return this;
        }

        public IFluentEspresso AddMilk(int amount)
        {
            ingrediens.Add("milk");
            amountInCup += amount;
            return this;
        }

        public bool CanItBeInCup(Func<int, bool> func)
        {
            if (func(this.amountInCup)) {
                return true;
            }
            return false;
        }
    }
}