using Visma.Christmas.Bakery.RecipesBook.Baking;
using Visma.Christmas.Bakery.RecipesBook.Book;
using Visma.Christmas.Bakery.RecipesBook.Operations;

namespace Visma.Christmas.Bakery.RecipesBook.Recipes;

public class InteractiveRecipe<T>
    where T : IBakedOutput
{
    public class MixtureBuilder(InteractiveRecipe<T> recipe)
    {
        private readonly InteractiveRecipe<T> _recipe = recipe;
        private readonly Mixture _mixture = new();
        private IOperation? _operation;

        public MixtureBuilder Mix(Ingredient ingredient)
        {
            _mixture.Ingredients.Add(ingredient);
            return this;
        }

        public MixtureBuilder With(Ingredient ingredient)
        {
            _mixture.MixedIngredients.Add(ingredient);
            return this;
        }

        public MixtureBuilder UseMixer()
        {
            _operation = new Mixer();
            return this;
        }

        public MixtureBuilder UseOven()
        {
            _operation = new Oven();
            return this;
        }

        public MixtureBuilder UseCutter()
        {
            _operation = new Cutter();
            return this;
        }

        public InteractiveRecipe<T> Build()
        {
            _recipe.Mixtures.Add((_mixture, _operation));
            return _recipe;
        }
    }

    public required IRecipe<T> Recipe { get; init; }
    public List<(Mixture, IOperation?)> Mixtures { get; init; } = [];

    public MixtureBuilder Mixture() => new(this);
    public Ingredient GetIngredient(string name) => Recipe.AllIngredients.First(i => i.Name == name);

    public T Bake()
    {
        var mixture = new Mixture();
        foreach (var (m, o) in Mixtures)
        {
            mixture.Ingredients.AddRange(m.Ingredients);
            mixture.MixedIngredients.AddRange(m.MixedIngredients);

            o?.Execute(mixture);
        }

        return Recipe.Bake(mixture);
    }
}