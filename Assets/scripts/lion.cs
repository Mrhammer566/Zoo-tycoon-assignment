using UnityEngine;

public class Lion : Animal, IInteractable, IFeedable
{
    public Lion()
    {
        Name = "Lion";
        HabitatType = "Savannah";
    }

    public override void MakeSound()
    {
        Debug.Log("Lion: Roar!");
    }

    public void Interact()
    {
        Debug.Log("You observe the mighty lion in its habitat.");
    }

    public void Feed()
    {
        Debug.Log("You feed the lion some meat.");
    }
}