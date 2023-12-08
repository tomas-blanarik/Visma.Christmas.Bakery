using Visma.Christmas.Bakery.RecipesBook.Baking;
using Visma.Christmas.Bakery.RecipesBook.Book;
using Visma.Christmas.Bakery.RecipesBook.Output;

namespace Visma.Christmas.Bakery.RecipesBook.Recipes;

public class GingerbreadRecipe : IRecipe<Gingerbread>
{
    private readonly List<Step> _steps = [];

    public GingerbreadRecipe()
    {
        BuildSteps();
    }

    public string Name => "Gingerbread";
    public string Description => "Last year, these gingerbreads were baked in Kamila Magálova's show and they promised that they " +
        "would be ready immediately and would remain soft forever, so I tried them and here it is!";

    public Ingredient[] AllIngredients =>
    [
        new Ingredient("Honey", 160, IngredientType.Grams),
        new Ingredient("Sugar", 160, IngredientType.Grams),
        new Ingredient("Butter", 120, IngredientType.Grams),
        new Ingredient("Egg", 2, IngredientType.Pieces),
        new Ingredient("Flour", 500, IngredientType.Grams),
        new Ingredient("Baking soda", 1, IngredientType.Teaspoons),
        new Ingredient("Cinnamon", 1, IngredientType.Teaspoons),
        new Ingredient("Ginger", 1, IngredientType.Teaspoons)
    ];

    public Step[] Steps => [.. _steps];

    public Gingerbread Bake()
    {
        // print out some nice christmasy message that we are baking gingerbread
        Console.WriteLine("Ho, ho, ho! Our gingerbread is baking!");
        Thread.Sleep(4000);
        Console.WriteLine("It's almost done!");
        Thread.Sleep(3000);
        Console.WriteLine("It's done! Let's eat it!");

        return new Gingerbread();
    }

    public Gingerbread Bake(Mixture mixture)
    {
        // print out some nice christmasy message that we are baking gingerbread
        Console.WriteLine("Ho, ho, ho! Our gingerbread is baking!");
        Thread.Sleep(4000);
        Console.WriteLine("It's almost done!");
        Thread.Sleep(3000);
        Console.WriteLine("It's done! Let's eat it!");

        return new Gingerbread();
    }

    private void BuildSteps()
    {
        _steps.Add(new Step("Ingredients", "Let's prepare all the ingredients we need for the recipe."));
        _steps.Add(new Step("Honey mixture", "Let the honey, sugar and game come to a boil.", SelectIngredients("Honey", "Sugar", "Butter")));
        _steps.Add(new Step("Dough preparing", "Mix flour with baking soda and cinnamon.", SelectIngredients("Flour", "Baking soda", "Cinnamon")));
        _steps.Add(new Step("Mixing with honey", "Add the slightly cooled honey mixture and mix.", SelectIngredients("Honey", "Sugar", "Butter")));
        _steps.Add(new Step("Mixing with honey 2", "Add eggs to the not completely cooled mass.", SelectIngredients("Egg")));
        _steps.Add(new Step("Making the dough", "We process the dough, which we wrap and let it rest for at least 2 hours."));
        _steps.Add(new Step("Processing", "Then we roll it out to 5 mm and cut out different shapes. Before baking, brush them with beaten egg and bake for about 10 minutes at a temperature of 175 °C. " +
            "After baking, brush them with a beaten yolk with a spoonful of milk. And here they are already baked and undecorated."));
    }

    private Ingredient[] SelectIngredients(params string[] ingredientNames) =>
        AllIngredients.Where(ingredient => ingredientNames.Contains(ingredient.Name)).ToArray();
}