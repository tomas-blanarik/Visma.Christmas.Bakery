using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Operations;

public class Pan : IOperation
{
    public string Name => "Pan";
    public string Description => "Pans the mixture";
    public TimeSpan Duration => TimeSpan.FromSeconds(1);

    public void Execute(Mixture mixture)
    {
        Console.WriteLine("Panning following ingredients: ");
        foreach (var ingredient in mixture.Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }
    }
}