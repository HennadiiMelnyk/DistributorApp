using DistributorApp.Exceptions;
using DistributorApp.Factories;

namespace DistributorApp.Services;

public class DrinkManager : IDrinkManager
{
    private readonly DrinkManagerFactory _drinkManagerFactory;

    public DrinkManager(DrinkManagerFactory drinkManagerFactory)
    {
        _drinkManagerFactory = drinkManagerFactory;
    }

    /// <inheritdoc />
    public Decimal CalculateDrinkPrice(string drinkName)
    {
        var commission = 30;

        var drink = _drinkManagerFactory.GetDrinkByName(drinkName);
        if (drink == null)
        {
            throw new DistributorAppException("Drink not found by key.");
        }

        return drink.GetPrice() +(drink.GetPrice() * commission / 100);

    }
}