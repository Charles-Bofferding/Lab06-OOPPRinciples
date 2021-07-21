using System;


/// <summary>
/// Animal class, it is the base class
/// </summary>
public abstract class Animal
{
	public Animal()
	{
		Stomach = 0;
	}

	//Setting up properties for inheritance
	public abstract int Stomach { get; set; }
	public virtual int Legs { get; set; }
	
	//Setting up methods for inheritance
	public abstract void Call();
	public virtual void Eat()
	{
		Stomach++;
	}


}
