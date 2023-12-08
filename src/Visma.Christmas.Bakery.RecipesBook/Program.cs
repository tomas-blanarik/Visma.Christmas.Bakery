using Visma.Christmas.Bakery.RecipesBook.Baking;
using Visma.Christmas.Bakery.RecipesBook.Output;
using Visma.Christmas.Bakery.RecipesBook.Recipes;

public static class Program
{
    public static void Main(string[] _)
    {
        // var recipe = new GingerbreadRecipe();

        // var gingerbread = BakingProcessor.Bake(recipe);
        // gingerbread.Eat();

        // 2nd way
        var recipe = new InteractiveRecipe<Gingerbread>
        {
            Recipe = new GingerbreadRecipe()
        };

        var gingerbread = recipe
            .Mixture()
                .Mix(recipe.GetIngredient("Honey"))
                .With(recipe.GetIngredient("Sugar"))
                .UseMixer()
                .Build()
            .Mixture()
                .Mix(recipe.GetIngredient("Flour"))
                .With(recipe.GetIngredient("Egg"))
                .UseMixer()
                .Build()
            .Mixture()
                .Mix(recipe.GetIngredient("Baking soda"))
                .With(recipe.GetIngredient("Cinnamon"))
                .With(recipe.GetIngredient("Ginger"))
                .UseMixer()
                .Build()
            .Mixture()
                .UseOven()
                .Build()
            .Bake();

        gingerbread.Eat();
    }


}
