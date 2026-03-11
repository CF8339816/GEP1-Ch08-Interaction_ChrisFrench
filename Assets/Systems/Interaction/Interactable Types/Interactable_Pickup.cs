using UnityEngine;

public class Interactable_Pickup : MonoBehaviour, IInteractable

{

    public bool debugEnabled = false;
     


    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted with " + gameObject.name);

         InventoryManager.Instance.Gems += 1; // tells trhe interact to add a gem with eachg pickup to the inventory manager using the gcp
        

        Destroy(gameObject);    
    }

    public void Focused()
    {

    }
    public void UnFocused()
    {

    }
}
