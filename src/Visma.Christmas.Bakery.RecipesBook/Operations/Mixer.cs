using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Operations;

public class Mixer : IOperation
{
    public string Name => "Mixer";
    public string Description => "Mixes ingredients";
    public TimeSpan Duration => TimeSpan.FromSeconds(5);

    public void Execute(Mixture mixture)
    {
        Console.WriteLine("Mixing following ingredients: ");
        foreach (var ingredient in mixture.Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }

        Console.WriteLine("Mixing with ingredients: ");
        foreach (var ingredient in mixture.MixedIngredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }
    }
}
