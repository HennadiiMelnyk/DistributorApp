using DistributorApp.Services;
using NSubstitute;
using NUnit.Framework;

namespace DistributorApp.Tests.Services;

/// <summary>
/// Contains tests for <see cref="IDrinkManager"/>
/// </summary>

public class DrinkManagerTests
{
    private IDrinkManager _drinkManager;
    
    [SetUp]
    public void SetUp()
    {
        _drinkManager = Substitute.For<IDrinkManager>();
    }

    //[TestCase("Chocolate")]
    [Test]
    public void CreateChocolateDrink()
    {
        // Arrange 
        var chocolateDrink = "";
        // Act
        var chocolatePrice = _drinkManager.CalculateDrinkPrice(chocolateDrink);
        // Assert
        //Assert.That(chocolatePrice, Is.Not.Null);

    }
}