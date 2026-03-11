//using System.Diagnostics;
using UnityEngine;

public class InteractMessage : MonoBehaviour,IInteractable
{

 //public bool debugEnabled = false;
    private UIManager uiManager;
    [Header("message")]
    [SerializeField] private string message;    



    private void Awake()
    {
        uiManager =ServiceHub.Instance.GetComponent<UIManager>();    
        
        if (uiManager == null) Debug.LogError("UIManager not found in service hub  ensure it is properly set up ");
        
    }


    public void Interact()
    {
        //if (debugEnabled) Debug.Log("Interacted with " + gameObject.name);
        uiManager.DisplayMessage();



    }





    public void Focused()
    {

    }


    public void UnFocused()
    {

    }



}
