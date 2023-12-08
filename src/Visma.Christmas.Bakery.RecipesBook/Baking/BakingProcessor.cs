using Visma.Christmas.Bakery.RecipesBook.Book;

namespace Visma.Christmas.Bakery.RecipesBook.Baking;

public class BakingProcessor
{
    public static T Bake<T>(IRecipe<T> recipe) where T : IBakedOutput
    {
        // first let's print out the recipe name and nice warm welcome message
        Console.WriteLine($"Ho, ho, ho! Let's bake some {recipe.Name}!");
        // add some delimiter to make it nicer, christmas theme
        Console.WriteLine("--------------------------------------------------");
        Console.ReadKey();

        Console.WriteLine($"Here is the recipe for {recipe.Name}:");
        Console.WriteLine(recipe.Description);
        Console.ReadKey();

        // add some delimiter to make it nicer, christmas theme
        Console.WriteLine("--------------------------------------------------");
        Thread.Sleep(500);

        // let's print out the ingredients
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in recipe.AllIngredients)
        {
            Console.WriteLine($"{ingredient.Name} - {ingredient.Amount} {ingredient.Type}");
        }

        // add some delimiter to make it nicer, christmas theme
        Console.WriteLine("--------------------------------------------------");
        Thread.Sleep(500);

        // let's print out the steps
        Console.WriteLine("Okay, let's start baking!");
        Console.WriteLine("Here goes nothing!");
        Console.WriteLine();
        Console.WriteLine("Steps:");

        int i = 1;
        foreach (var step in recipe.Steps)
        {
            Console.WriteLine($"Step #{i}. {step.Name}");
            Console.WriteLine(step.Description);
            Console.WriteLine();

            if (step.Ingredients != null)
            {
                Console.WriteLine("Ingredients for this step:");
                foreach (var ingredient in step.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Name} - {ingredient.Amount} {ingredient.Type}");
                }
            }

            Console.WriteLine("Processing...");

            // add some delimiter to make it nicer, christmas theme
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Thread.Sleep(GetRandomWaitingTime());
            i++;
            Console.ReadKey();
        }

        T baked = recipe.Bake();

        // add some delimiter to make it nicer, christmas theme
        Console.WriteLine("--------------------------------------------------");
        Thread.Sleep(500);

        return baked;
    }

    private static int GetRandomWaitingTime()
    {
        var random = new Random();
        return random.Next(500, 3000);
    }
}