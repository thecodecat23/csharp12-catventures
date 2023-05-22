namespace CatCafe;

// Define another derived class 'WildCat' with an additional primary constructor parameter 'favoriteHuntingSpot'.
public class WildCat(string name, int age, string favoriteHuntingSpot) : Cat(name, age)
{
    // Initialize property 'FavoriteHuntingSpot' with the value of the primary constructor parameter.
    public string FavoriteHuntingSpot { get; } = favoriteHuntingSpot;

    // Override the 'Meow' method to provide a specific implementation for 'WildCat'.
    public override void Meow() =>
        Console.WriteLine($"{Name} meows while prowling around {FavoriteHuntingSpot}.");
}