using UnityEngine;

public class Cat : Animal
{
    // INHERITANCE: Cat inherits from Animal

    // POLYMORPHISM: Overriding the Speak method from Animal
    public override void Speak()
    {
        Debug.Log(Name + " says: Meow!");
    }
}