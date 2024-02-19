using DistributorApp.Models.Ingridients;

namespace DistributorApp.Creators;

public class ChocolateCreator : DrinkCreator
{
    public override decimal GetPrice()
    {
        var milk = new Milk();
        var chocolate = new Chocolate();
        var water = new Water();
        var sugar = new Sugar();

        var sum = 2 *milk.IngredientPrice 
                  + 3*chocolate.IngredientPrice 
                  + water.IngredientPrice
                  + sugar.IngredientPrice;

        return sum;
    }
}