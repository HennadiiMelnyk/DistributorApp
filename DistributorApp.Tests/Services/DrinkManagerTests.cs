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

    [Test]
    public void TestGetChocolateDrinkPrice()
    {
        // Arrange 
        var chocolateDrink = "Chocolate";
        var expectedPrice = 5.33m;

        // Act
        var chocolatePrice = _drinkManager.CalculateDrinkPrice(chocolateDrink);

        // Assert
        Assert.That(chocolatePrice, Is.EqualTo(expectedPrice));
        Assert.Pass();
    }
}