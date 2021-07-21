## Lab 6 and 7, Heirarchy Zoo

# Introduction

The purpose of this project is to create a zoo of animal classes that use inheritance and interfaces to populate 
each animal with a variety of methods and properties.

The general outline can be seen in the heirarchy graph below
[Graph](Zoo-Class-Heirarchy.jpeg)

# OOP Principles
Encapsulation
Wrapping up the eat method as well as the stomach int together is ian example of encapsulation. Both are contained in 
the animal class. The same is true for wingspan and flap, which uses the wingspan number to create an output string.

Abstraction
Pulling the background or common information from a specific class to higher up. This can be seen in the stomach int value
which is held in animal because all the animals will have it. It can also be seen in the swim method that is in the 
Fish class so that all fish will be able to swim, but not the birds (yes I know some birds swim but we are ignoring that)

Inheritance
When a class includes the child class of a seperate parent class brings in properties of that class. Examples are the 
Salmon and ClownFish class both having SwimSpeed values because they both implement the Fish class. Another example is
all of the birds having a wingspan property.

Polymorphism
This means that one method may have a different way to run in seperate classes. This can be seen in the repeat method on 
the Bird class. Eagle and Ostrich both just look at you while the Parrot class will squack and repeat the phrase back at you.
Another example is the Salmon and CLownFish classes both having different Home properties, because their specific class
modifies that property specific to them.

# Interfaces

In C# you can only have a class inherit from one other class. A way around this limitation is to create 
interfaces. These are class like objects without a constructor that can tell a class which they are 
added onto to create certain methods and guide the development.









Lab 06 instructions

An introduction to the project
Your digital UML drawing of your zoo
Create your own technical documentation. Breakdown and define each of the OOP principles in your own words.
Provide under each OOP definition a couple (you do not have to define all) of examples of how you are applying this into your project.

Lab 07 instructions
Add the following to your current readme from Lab 5/Part 1:

Define what an interface is in your own words
Describe what your interfaces are, where are they being implemented, and why. Provide Examples.
Updated diagram with your interfaces mapped out.