using UnityEngine;
using UnityEngine.UI;

public class InteractionManager : MonoBehaviour
{
    public Text interactionText;
    private IInteractable currentInteractable;

    void Update()
    {
        if (currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.Interact();
            interactionText.text = "You interacted with the animal!";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            currentInteractable = other.GetComponent<IInteractable>();
            interactionText.text = "Press E to interact.";
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (currentInteractable != null)
        {
            currentInteractable = null;
            interactionText.text = "";
        }
    }
}