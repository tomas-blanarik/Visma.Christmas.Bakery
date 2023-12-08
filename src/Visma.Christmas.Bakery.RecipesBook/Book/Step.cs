namespace Visma.Christmas.Bakery.RecipesBook.Book;

public class Step(string name, string description, params Ingredient[] ingredients)
{
    /// <summary>
    /// Name of the step
    /// </summary>
    public string Name { get; } = name;

    /// <summary>
    /// Describes the step in detail
    /// </summary>
    public string Description { get; } = description;

    /// <summary>
    /// Ingredients needed for the step
    /// </summary>
    public Ingredient[] Ingredients { get; } = ingredients;
}