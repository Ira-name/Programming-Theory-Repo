using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animal dog;
    public Animal cat;

    void Start()
    {
        // Create Dog and Cat objects
        dog = new GameObject("Dog").AddComponent<Dog>();
        cat = new GameObject("Cat").AddComponent<Cat>();

        // Set names using encapsulation
        dog.Name = "Buddy";
        cat.Name = "Whiskers";

        // ABSTRACTION: Calling Speak() on both animals, without knowing the specifics
        dog.Speak(); // Outputs: Buddy says: Woof!
        cat.Speak(); // Outputs: Whiskers says: Meow!
    }
}