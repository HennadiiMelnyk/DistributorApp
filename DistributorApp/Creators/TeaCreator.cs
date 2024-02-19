using DistributorApp.Models.Ingridients;

namespace DistributorApp.Creators;

public class TeaCreator : DrinkCreator
{
    public override decimal GetPrice()
    {
        var tea = new Tea();
        var water = new Water();

        var sum = tea.IngredientPrice
                  + 2 * water.IngredientPrice;

        return sum;
    }
}