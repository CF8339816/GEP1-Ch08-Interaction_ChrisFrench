using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEditor.Search;

public class UIManager : MonoBehaviour
{

    [SerializeField] bool debugEnabled = false;
    [SerializeField] private TMP_Text signMessageText;
    [SerializeField] private TMP_Text gnomeMessageText;
   
    private string currentMessage = "";
    private Coroutine fadeCoroutine;

    [Header("Alpha message")]

    [SerializeField] float messageDuration = 3f;

    [SerializeField] float fadeOutTime = .5f;



    [Header("Interact Prompt ")]
    [SerializeField] private TMP_Text promptMessageText;
    [SerializeField] private string prompt;
    //[SerializeField] private TMP_Text messageText;

    private void Start()
    {
       // currentMessage = "";
       
    }


    public void DisplayMessage(string message)
    {
       // currentMessage = message;
        // messageText.text = currentMessage;


        if (fadeCoroutine!= null)
        {
            StopCoroutine(fadeCoroutine);
        }


        fadeCoroutine = StartCoroutine(displayMessageAndFade(message));


    }

    public void ShowPrompt()
    {
        promptMessageText.text = prompt;
    }

    public void HidePrompt()
    {
        promptMessageText.text = "";
    }





    //public void ClearMessage(string message)
    //{
    //    currentMessage = "";
    //    messageText.text = currentMessage;



    //}



    private IEnumerator displayMessageAndFade(string message)
    {

        signMessageText.text= message;
        signMessageText.alpha = 1;

        
      
        float elapsedTime= 0f;
        Color OriginalColor = signMessageText.color;



        while(elapsedTime < messageDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutTime);

            signMessageText.alpha = alpha;
           // messageText.color = new Color(OriginalColor.r, OriginalColor.g, OriginalColor.b, alpha);

            yield return null;

        }




        signMessageText.text = currentMessage;
        //currentMessage = message;

        yield return  new WaitForSeconds(3f);

        signMessageText.text = "This is your last warning overide ya Scruff";

    }
}
