using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{

    [SerializeField] bool debugEnabled = false;
    [SerializeField] private TMP_Text messageText;
    private string currentMessage = "";
    private Coroutine fadeCoroutine;
    private void Start()
    {
        currentMessage = "";
       
    }


    public void DisplayMessage(string message)
    {
       // currentMessage = message;
        // messageText.text = currentMessage;


        if (fadeCoroutine!= null)
        {
            StopCoroutine(fadeCoroutine);
        }


        fadeCoroutine = StartCoroutine(FadeOutInfoText(message));


    }

    //public void ClearMessage(string message)
    //{
    //    currentMessage = "";
    //    messageText.text = currentMessage;



    //}



    private IEnumerator FadeOutInfoText(string message)
    {
        messageText.text = currentMessage;
        //currentMessage = message;

        yield return  new WaitForSeconds(3f);

        messageText.text = "This is your last warning overide ya Scruff";

    }
}
