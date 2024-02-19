namespace DistributorApp.Services;

/// <summary>
/// Drink manager for calculate drink price.
/// </summary>
public interface IDrinkManager
{
    Decimal CalculateDrinkPrice(string drinkName);
}