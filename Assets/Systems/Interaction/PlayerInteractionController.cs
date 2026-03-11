using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionController : MonoBehaviour
{

    public bool debugEnabled = false;

   private IInteractable targetInteractable;

    [SerializeField] private GameObject debugCurrentInteractable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = other.gameObject;

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;

        }

    }


    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (debugEnabled) Debug.Log("attempting to Interact ");

            if (targetInteractable != null)
            {
               // if (debugEnabled) Debug.Log("attempting to Interact " );

                targetInteractable.Interact();
            }
        }       
    }




}
