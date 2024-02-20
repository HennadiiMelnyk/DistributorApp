using DistributorApp.Factories;
using DistributorApp.Services;
using NSubstitute;
using NUnit.Framework;

namespace DistributorApp.Tests;

/// <summary>
/// Contains test for <see cref="IDrinkManager"/>
/// </summary>
public class DrinkManagerTests
{
    private IDrinkManager _drinkManager;
    private DrinkManagerFactory _drinkManagerFactory;

    [SetUp]
    public void Setup()
    {
        _drinkManagerFactory = Substitute.For<DrinkManagerFactory>();
        _drinkManager = new DrinkManager(_drinkManagerFactory);
    }

    [TestCase("Chocolate", 5.33)]
    [TestCase("Allonge", 1.82)]
    [TestCase("Tea", 3.12)]
    [TestCase("Espresso", 1.56)]
    [TestCase("Cappuccino", 3.51)]
    public void TestGetChocolateDrinkPrice(string drinkName, Decimal expectedPrice)
    {
        // Arrange 

        // Act
        var drinkPrice = _drinkManager.CalculateDrinkPrice(drinkName);

        // Assert
        Assert.That(drinkPrice, Is.EqualTo(expectedPrice).Within(0.1));
    }
}