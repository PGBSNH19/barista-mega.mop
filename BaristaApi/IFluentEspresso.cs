using System;

namespace BaristaApi
{
    public interface IFluentEspresso
    {
        Beverage ToBeverage();
        IFluentEspresso AddEspresso(int amount);
        IFluentEspresso AddMilk(int amount);
        bool CanItBeInCup(Func<int, bool> func);
    }
}