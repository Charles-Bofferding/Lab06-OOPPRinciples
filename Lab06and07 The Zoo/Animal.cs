using System;


/// <summary>
/// Animal class, it is the base class
/// </summary>
public abstract class Animal
{
	public Animal()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	//Setting up properties for inheritance
	public abstract int Stomach { get; set; }
	public virtual int Legs { get; set; }
	
	//Setting up methods for inheritance
	public abstract void Eat();
	public virtual void Call()
	{
		Console.WriteLine("I am a default animal response");
	}


}
