namespace CatCafe;

// Define an abstract base class 'Cat' with primary constructor parameters 'name' and 'age'.
public abstract class Cat(string name, int age)
{
    // Initialize properties 'Name' and 'Age' with the values of the primary constructor parameters.
    public string Name { get; } = name;
    public int Age { get; } = age;

    // Declare an abstract method 'Meow'.
    public abstract void Meow();
}