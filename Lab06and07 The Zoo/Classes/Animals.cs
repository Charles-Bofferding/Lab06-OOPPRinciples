using System;
using Lab06and07_The_Zoo;
using Lab06and07_The_Zoo.Interface;

/// <summary>
/// Salmon, fish with swim speed of 40 and a home of "a beautiful stream up north
/// </summary>
public class Salmon : Fish, IHide, IHunt
{
	public Salmon()
	{
		SwimSpeed = 40;
	}

	public override int SwimSpeed { get; set; }
	public override int Stomach { get; set; }

    public string Approach()
    {
        return "The salmon swims quickly to it's target";
    }

    public string Attack()
    {
        return "The salmon bites at and swallows the prey";
    }

    public string FindTarget()
    {
        return "Salmon stalk coastal water for smaller marine life";
    }

    public string[] HidesFrom()
    {
        string[] output = new string[] { "Bear", "Eagle", "Fisherman" };
        return output;
    }

    public string HidingSpot()
    {
        return "Hiding in the fresh water streams to protect their young";
    }

    public override string Swim()
    {
        string output = $"I swim forward at a movement speed of {SwimSpeed} feet per 6 seconds";
		return output;
    }
}

/// <summary>
/// Clown Fish, fish with swim speed of 5 and a home of "a see anemone"
/// </summary>
public class ClownFish : Fish, IHide
{
	public ClownFish()
	{
		SwimSpeed = 5;
	}

	public override int SwimSpeed { get; set; }

    public override int Stomach { get; set; }

	public override string Swim()
	{
		string output = $"I swim forward at a movement speed of {SwimSpeed} feet per 6 seconds";
		return output;
	}

	public string[] HidesFrom()
    {
		string[] output = new string[] { "Stingray", "Shark", "Eel" };
		return output;
	}

    public string HidingSpot()
    {
        return "Clown Fish hide in the stinging tentacles of their anemone home";
    }



}

/// <summary>
/// Emu, bird with a wingspan of 1 foot (rounded 8 inches), no repeating of words, 
/// </summary>
public class Ostrich : Bird, IHide
{
	public Ostrich()
	{
		Wingspan = 78;
	}

    public override int Wingspan { get; set; }
    public override int Stomach { get; set; }

    public override void Call()
    {
        Console.WriteLine("*Staring Intensifies*");
    }

    public override string Flap()
    {
        return $"The Ostrich flaps it's {Wingspan} inch wings";
    }

    public string[] HidesFrom()
    {
        string [] output = new string[] { "Cheetah", "Lion", "Leopard"};
		return output;
    }

    public string HidingSpot()
    {
        return "Shoving it's head in the sand";
    }
}

/// <summary>
/// Parrot, a talkative bird
/// </summary>
public class Parrot : Bird
{
	public Parrot()
	{
		Wingspan = 48;

	}

    public override int Wingspan { get; set; }
    public override int Stomach { get; set; }
	private readonly string[] MyWords = new[] { "Cracker", "Pretty Bird", "Why Hello There" };

	public override void Call()
    {
		Console.WriteLine("Poly wants a cracker, SQUACK!");
	}

    public override string Flap()
    {
		return $"The Parrot flaps it's {Wingspan} inch wings";
	}

    public override string Repeat(string phrase)
    {
		string output = $"SQUACK, {phrase}, SQUACK";
		return output;
	}

    public new string[] KnownWords()
	{
		return MyWords;
	}

}

/// <summary>
/// Eagle, a bird with a wingspan of 72 inches
/// </summary>
public class Eagle : Bird, IHunt
{
	public Eagle()
	{
		Wingspan = 72;
	}

    public override int Wingspan { get; set; }
    public override int Stomach { get; set; }

	public override string Flap()
	{
		return $"The Eagle flaps it's {Wingspan} inch wings";
	}

	public override void Call()
	{
		Console.WriteLine("Ki Ki Ki");
	}

	public string Approach()
    {
        return "The eagle begins a frightening descent from the air down to the target";
    }

    public string Attack()
    {
        return "The eagle strikes with mighty beak and talon";
    }

    public string FindTarget()
    {
        return "The eagle spots it's prey from far above with spectacular vision.";

	}


}

