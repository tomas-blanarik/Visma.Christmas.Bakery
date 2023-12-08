using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Operations;

public class Oven : IOperation
{
    public string Name => "Oven";
    public string Description => "Bakes the mixture";
    public TimeSpan Duration => TimeSpan.FromSeconds(10);

    public void Execute(Mixture mixture)
    {
        Console.WriteLine("Baking following ingredients: ");
        foreach (var ingredient in mixture.Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }
    }
}
