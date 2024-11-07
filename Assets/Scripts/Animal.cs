using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ABSTRACTION: The method Speak() is defined at a high level in the Animal class.
    public abstract void Speak();

    // ENCAPSULATION: Private field for the name, with getter and setter
    private string name;

    public string Name
    {
        get { return name; }  // Getter
        set { name = value; } // Setter
    }
}