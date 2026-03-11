using UnityEngine;

public class Interactable_Pickup : MonoBehaviour, IInteractable

{

    public bool debugEnabled = false;


    public void Focused()
    {

    }

    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted with " + gameObject.name);
    }

    public void UnFocused()
    {

    }
}
