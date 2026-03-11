//using System.Diagnostics;
using UnityEngine;

public class InteractMessage : MonoBehaviour, IInteractable
{

 //public bool debugEnabled = false;
    
    [Header("message")]
    [SerializeField] private string message;
    [SerializeField] private UIManager uiManager;

    private void Start()
     //    private void start()
    // private void Awake()
    {
        uiManager = ServiceHub.Instance.UIManager;    
        
        if (uiManager == null) Debug.LogError("UIManager not found in service hub  ensure it is properly set up ");
        
    }

    
    public void Interact()
    {
        //if (debugEnabled) Debug.Log("Interacted with " + gameObject.name);
        uiManager.DisplayMessage(message);



    }





    public void Focused()
    {

    }


    public void UnFocused()
    {

    }



}
