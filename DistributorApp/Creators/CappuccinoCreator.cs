using DistributorApp.Models.Ingridients;

namespace DistributorApp.Creators;

public class CappuccinoCreator : DrinkCreator
{
    public override decimal GetPrice()
    {
        var coffee = new Coffee();
        var chocolate = new Chocolate();
        var water = new Water();
        var cream = new Cream();

        var sum = coffee.IngredientPrice
                  + chocolate.IngredientPrice
                  + water.IngredientPrice
                  + cream.IngredientPrice;

        return sum;
    }
}