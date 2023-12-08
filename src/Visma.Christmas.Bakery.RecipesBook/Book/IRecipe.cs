using Visma.Christmas.Bakery.RecipesBook.Baking;

namespace Visma.Christmas.Bakery.RecipesBook.Book;

public interface IRecipe<TBakedOutput> where TBakedOutput : IBakedOutput 
{
    string Name { get; }
    string Description { get; }
    Ingredient[] AllIngredients { get; }
    Step[] Steps { get; }

    TBakedOutput Bake();
    TBakedOutput Bake(Mixture mixture);
}