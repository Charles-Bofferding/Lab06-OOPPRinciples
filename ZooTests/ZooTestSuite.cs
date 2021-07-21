using System;
using Xunit;

namespace ZooTests
{
    public class ZooTestSuite
    {
        //Test Requirements
        //Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class.
        //Test that the classes that implement the interface actually implement it
        //Test inheritance
        //Test Polymorphism
        //Prove methods have been overridden
        //Prove that one of your concrete animals is an Animal

        //Salmon
        [Fact]
        public void Salmon1()
        {
            Salmon test = new();

            Assert.Equal(40, test.SwimSpeed);
            Assert.Equal("I swim forward at a movement speed of 40 feet per 6 seconds", test.Swim());
        }

        //Clown Fish
        [Fact]
        public void ClownFish1()
        {
            ClownFish test = new();

            Assert.Equal(5, test.SwimSpeed);
            //Interface
            Assert.Equal("Clown Fish hide in the stinging tentacles of their anemone home", test.HidingSpot());
        }

        //Ostrich
        [Fact]
        public void Ostrich1()
        {
            Ostrich test = new();

            Assert.Equal(78, test.Wingspan);
            //Interface
            Assert.Equal("Shoving it's head in the sand", test.HidingSpot());
        }

        //Parrot
        [Fact]
        public void Parrot1()
        {
            Parrot test = new();
            string[] TestWords = new[] { "Cracker", "Pretty Bird", "Why Hello There" };

            //Polymorphism: overwrote standard bird repeat
            Assert.Equal("SQUACK, poly want a cracker, SQUACK", test.Repeat("poly want a cracker"));
            Assert.Equal(TestWords, test.KnownWords());
        }

        //Eagle
        [Fact]
        public void Eagle1()
        {
            Eagle test = new();

            //Interface
            Assert.Equal("The eagle spots it's prey from far above with spectacular vision.", test.FindTarget());
            Assert.Equal("The bird stares at you", test.Repeat("Testing"));
        }

        //Animal Proof, the eagle can do what all animals can do, eat
        [Fact]
        public void Animal1()
        {
            Eagle test = new();
            test.Eat();
            test.Eat();
            //Interface
            Assert.Equal(2, test.Stomach);
        }

    }
}
