using DistributorApp.Models.Ingridients;

namespace DistributorApp.Creators;

public class AllongeCoffeeCreator : DrinkCreator
{
    public override decimal GetPrice()
    {
        var coffee = new Coffee();
        var water = new Water();

        var sum = coffee.IngredientPrice
                  + 2 * water.IngredientPrice;

        return sum;
    }
}