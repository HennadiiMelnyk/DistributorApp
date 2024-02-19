namespace DistributorApp.Creators;

/// <summary>
/// Drink creator with proper price.
/// </summary>
public abstract class DrinkCreator
{
    /// <summary>
    /// Creating drink with proper calculated price.
    /// </summary>
    /// <returns></returns>
    public abstract decimal GetPrice();
}