using UnityEngine;

public class Tiger : Animal, IInteractable, IFeedable
{
    public Tiger()
    {
        Name = "Tiger";
        HabitatType = "Jungle";
    }

    public override void MakeSound()
    {
        Debug.Log("Tiger: Growl!");
    }

    public void Interact()
    {
        Debug.Log("You watch the tiger stealthily move through the jungle.");
    }

    public void Feed()
    {
        Debug.Log("You feed the tiger some fresh meat.");
    }
}