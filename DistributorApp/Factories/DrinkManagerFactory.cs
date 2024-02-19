using DistributorApp.Constants;
using DistributorApp.Creators;
using DistributorApp.Exceptions;

namespace DistributorApp.Factories;

/// <summary>
/// Drink Manager Factory.
/// </summary>
public class DrinkManagerFactory
{
    private readonly Dictionary<string, DrinkCreator> _drinkCreators = new(StringComparer.OrdinalIgnoreCase);

    public DrinkManagerFactory()
    {
        _drinkCreators[DistributorAppConstants.CAPPUCCINO_COFFEE] = new CappuccinoCreator();
        _drinkCreators[DistributorAppConstants.ALLONGE_COFFEE] = new AllongeCoffeeCreator();
        _drinkCreators[DistributorAppConstants.CHOCOLATE] = new ChocolateCreator();
        _drinkCreators[DistributorAppConstants.TEA] = new TeaCreator();
        _drinkCreators[DistributorAppConstants.ESPRESSO_COFFEE] = new EspressoCreator();
    }

    public DrinkCreator GetDrinkByName(string drinkName)
    {
        return _drinkCreators.TryGetValue(drinkName, out var result) ? result : default;
    }
}