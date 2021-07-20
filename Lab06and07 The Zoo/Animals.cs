using System;

/// <summary>
/// Salmon, fish with swim speed of 40 and a home of "a beautiful stream up north
/// </summary>
public class Salmon : Fish
{
	public Salmon()
	{
		SwimSpeed = 40;
	}

	public override int SwimSpeed { get; set; }

    public override string Swim()
    {
        string output = $"I swim forward at a movement speed of {SwimSpeed} feet per 6 seconds";
		return output;
    }
}

/// <summary>
/// Clown Fish, fish with swim speed of 5 and a home of "a see anemone"
/// </summary>
public class ClownFish : Fish
{
	public ClownFish()
	{
		SwimSpeed = 5;
	}

	public override int SwimSpeed { get; set; }

	public override string Swim()
	{
		string output = $"I swim forward at a movement speed of {SwimSpeed} feet per 6 seconds";
		return output;
	}

}

/// <summary>
/// Emu, bird with a wingspan of 1 foot (rounded 8 inches), no repeating of words, 
/// </summary>
public class Emu : Bird
{
	public Emu()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public override int WingSpan { get; set; }


}

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}