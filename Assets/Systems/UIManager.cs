using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] bool debugEnabled = false;
    [SerializeField] private TMP_Text messageText;
    private string currentMessage = "";

    private void Start()
    {
        currentMessage = "";
       
    }


    public void DisplayMessage(string message)
    {
        currentMessage = message;
        messageText.text = currentMessage;



    }

    public void ClearMessage(string message)
    {
        currentMessage = "";
        messageText.text = currentMessage;



    }

}
