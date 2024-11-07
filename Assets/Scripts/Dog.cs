using UnityEngine;

public class Dog : Animal
{
    // INHERITANCE: Dog inherits from Animal

    // POLYMORPHISM: Overriding the Speak method from Animal
    public override void Speak()
    {
        Debug.Log(Name + " says: Woof!");
    }
}