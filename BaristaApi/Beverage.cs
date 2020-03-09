using System.Collections.Generic;

public abstract class Beverage{
	List<string> Ingredients { get; }
    string CupType { get; }
}

class Espresso : Beverage
{
}

class Latte : Beverage
{
}