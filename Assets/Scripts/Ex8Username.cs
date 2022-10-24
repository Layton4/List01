using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex8Username : MonoBehaviour
{
    public TMP_InputField inputBox;
    public string username;

    public TextMeshProUGUI adviceText;
    public TextMeshProUGUI wellcomeText;

    public GameObject introduceUserPanel;
    public GameObject wellcomePanel;


    private void Start()
    {
        //At start there is only the inputField and the confirm button on screen
        introduceUserPanel.SetActive(true); 
        wellcomePanel.SetActive(false);
    }
    public void ConfirmButton() //The button to confirm our username
    {
        username = inputBox.text;

        if(username == "" || string.IsNullOrWhiteSpace(username)) //if we didn't fill the inputfield or we only have written blank spaces
        {
            adviceText.gameObject.SetActive(true); //A warning message appears remembering the user to fill the inputField to confirm.
        }
        else
        {  
            adviceText.gameObject.SetActive(false);
            introduceUserPanel.SetActive(false);

            wellcomePanel.gameObject.SetActive(true);
            wellcomeText.text = $"Hello, {username} and welcome to this amazing adventure!!"; //The wellcome message apears when the username is confirmed
        }
    }

    public void BackButton()
    {
        wellcomePanel.gameObject.SetActive(false);
        introduceUserPanel.SetActive(true);   
    }
}
