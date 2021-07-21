using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Bird : Animal
{
	public Bird()
	{
		Legs = 2;
	}

    ////New methods and things specific to Birds

    //Setting up properties for inheritance
    public abstract int Wingspan { get; set; }
    public virtual string[] KnownWords { get; set; }

    //Setting up methods for inheritance
    public abstract string Flap();
    public virtual string Repeat(string phrase)
    {
        return "The bird stares at you";

    }


}
