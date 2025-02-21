using UnityEngine;

public class PolarBear : Animal, IInteractable, IFeedable
{
    public PolarBear()
    {
        Name = "Polar Bear";
        HabitatType = "Arctic";
    }

    public override void MakeSound()
    {
        Debug.Log("Polar Bear: Growl!");
    }

    public void Interact()
    {
        Debug.Log("You watch the polar bear roam around the icy habitat.");
    }

    public void Feed()
    {
        Debug.Log("You feed the polar bear some fish.");
    }
}
