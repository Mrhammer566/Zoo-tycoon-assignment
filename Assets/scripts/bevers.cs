using UnityEngine;

public class Beaver : Animal, IInteractable, IFeedable
{
    public Beaver()
    {
        Name = "Beaver";
        HabitatType = "Wetlands";
    }

    public override void MakeSound()
    {
        Debug.Log("Beaver: Chatter!");
    }

    public void Interact()
    {
        Debug.Log("You observe the beaver building a dam.");
    }

    public void Feed()
    {
        Debug.Log("You give the beaver some wood to chew on.");
    }
}