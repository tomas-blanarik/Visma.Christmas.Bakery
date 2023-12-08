using System.Diagnostics;
using Visma.Christmas.Bakery.RecipesBook.Book;

namespace Visma.Christmas.Bakery.RecipesBook.Output;

public class Gingerbread : IBakedOutput
{
    public void Eat()
    {
        Console.WriteLine("Yummy! Nom nom nom...");
        Console.WriteLine("Here's your gingerbread!");

        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
    
        // open ../BakedStuff/gingerbread.html in browser
        Process.Start("cmd", $"/c start ../BakedStuff/gingerbread.html");
    }
}