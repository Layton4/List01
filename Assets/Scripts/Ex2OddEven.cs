using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Ex2OddEven : MonoBehaviour
{
    public int myNumber; //The number we will introduce and change whenever we want
    public TextMeshProUGUI selectionText; //The first text that indicates which number you have
    public TextMeshProUGUI resultText; //the conclusion text that tell you if the number is odd or even.

    private void Start()
    {
        selectionText.text = $"Your number is: {myNumber}"; //The initial number of the inspector is showed on screen
        resultText.gameObject.SetActive(false); //but we don't show id is odd or even until we acomplish the condition of press space
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            selectionText.text = $"Your number is: {myNumber}"; //the number is updated to the new number of the inspector
            if(myNumber%2 == 0)
            {
                resultText.text = $"The number {myNumber} is Even";
            }
            else
            {
                resultText.text = $"The number {myNumber} is Odd";
            }
            resultText.gameObject.SetActive(true); //we show if is Odd or Even the currentNumber
        }
    }
}
