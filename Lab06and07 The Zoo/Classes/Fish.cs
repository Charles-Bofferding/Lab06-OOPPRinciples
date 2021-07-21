using System;

/// <summary>
/// Fish class, inherits things from animal
/// </summary>
public abstract class Fish : Animal
{
	public Fish()
	{
        Legs = 0;
	}

    //Fish can only make very limited calls
    public override void Call()
    {
        Console.WriteLine("Blub blub blub");
    }

    //When you eat increase the contents of your stomach
    public override void Eat()
    {
        Stomach++;
    }

    ////New methods and things specific to fish

    //Setting up properties for inheritance
    public abstract int SwimSpeed { get; set; }
    public virtual string Home { get; set; }

    //Setting up methods for inheritance
    public abstract string Swim();
    public virtual String Migrate()
    {
        string myHome = $"I must go back home and return to {Home}";
        return myHome;
    }

}
