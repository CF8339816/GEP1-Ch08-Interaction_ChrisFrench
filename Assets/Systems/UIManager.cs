using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] bool debugEnabled = false;
    [SerializeField] private TMP_Text messageText;
    private string currentMessage = "";    

    public void DisplayMessage(string message)
    {
        currentMessage = message;
        messageText.text = currentMessage;



    }

}
