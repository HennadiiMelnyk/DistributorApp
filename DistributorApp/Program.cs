using DistributorApp.Constants;
using DistributorApp.Exceptions;
using DistributorApp.Factories;
using DistributorApp.Services;


var drinkManagerFactory = new DrinkManagerFactory();
IDrinkManager drinkManager = new DrinkManager(drinkManagerFactory);


Console.WriteLine("Distributor App menu!");
Console.WriteLine("Choose the drink from the list by typing his name:");
String[] options = {DistributorAppConstants.ALLONGE_COFFEE,
    DistributorAppConstants.CAPPUCCINO_COFFEE,
    DistributorAppConstants.TEA,
    DistributorAppConstants.ESPRESSO_COFFEE,
    DistributorAppConstants.CHOCOLATE,
};
           

while (true)
{
    PrintMenu(options); 
    var drinkKey = Console.ReadLine();

    try
    {
        var price = drinkManager.CalculateDrinkPrice(drinkKey);
        Console.WriteLine($"Price for drink:{drinkKey} will be {price} euros.");
    }
    catch (DistributorAppException ex)
    {
        Console.WriteLine("Sorry this drink not found.");
    }
}




static void PrintMenu(String[] options)
{
    foreach (String option in options)
    {
        Console.WriteLine(option);
    }
    Console.Write("Choose your option : ");
}








