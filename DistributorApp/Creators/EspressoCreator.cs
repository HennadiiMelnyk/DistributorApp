using DistributorApp.Models.Ingridients;

namespace DistributorApp.Creators;

public class EspressoCreator : DrinkCreator
{
    public override decimal GetPrice()
    {
        var coffee = new Coffee();
        var water = new Water();

        var sum = coffee.IngredientPrice
                  + water.IngredientPrice;

        return sum;
    }
}