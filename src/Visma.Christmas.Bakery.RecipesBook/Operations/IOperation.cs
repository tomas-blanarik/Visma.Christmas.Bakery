using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Operations;

public interface IOperation
{
    string Name { get; }
    string Description { get; }
    TimeSpan Duration { get; }

    void Execute(Mixture mixture);
}
