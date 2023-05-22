namespace CatCafe;

// Define a derived class 'HouseCat' with an additional primary constructor parameter 'favoriteToy'.
public class HouseCat(string name, int age, string favoriteToy) : Cat(name, age)
{
    // Initialize property 'FavoriteToy' with the value of the primary constructor parameter.
    public string FavoriteToy { get; } = favoriteToy;

    // Override the 'Meow' method to provide a specific implementation for 'HouseCat'.
    public override void Meow() =>
        Console.WriteLine($"{Name} meows while playing with {FavoriteToy}.");
}