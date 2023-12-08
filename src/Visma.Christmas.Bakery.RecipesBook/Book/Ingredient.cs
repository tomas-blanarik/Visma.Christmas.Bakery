namespace Visma.Christmas.Bakery.RecipesBook.Book;

public class Ingredient(string name, double amount, IngredientType type)
{
    public string Name { get; } = name;
    public double Amount { get; } = amount;
    public IngredientType Type { get; } = type;
}