using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Operations;

public class Cutter : IOperation
{
    public string Name => "Cutter";
    public string Description => "Cuts the dough";
    public TimeSpan Duration => TimeSpan.FromSeconds(1);

    public void Execute(Mixture mixture)
    {
        Console.WriteLine("Cutting following ingredients: ");
        foreach (var ingredient in mixture.Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }
    }
}