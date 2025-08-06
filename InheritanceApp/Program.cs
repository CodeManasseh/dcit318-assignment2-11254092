public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
 class Program
    {
        static void Main(string[] args)
        {
            Animal generic = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            generic.MakeSound();  // prints "Some generic sound"
            dog.MakeSound();      // prints "Bark"
            cat.MakeSound();      // prints "Meow"
        }
    }