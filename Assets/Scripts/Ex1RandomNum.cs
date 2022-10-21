using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex1RandomNum : MonoBehaviour
{

    public int minNum; //Min. value of the random number we want
    public int maxNum; //Max. value of the random number we want

    public int randomNumber; //The random number we will obtain when we push the button

    public TextMeshProUGUI randomNumBox; //textbox where we show the random number obtained
    public TextMeshProUGUI minNumBox;
    public TextMeshProUGUI maxNumBox;

    private void Start()
    {
        //the default values of the min., max., and random value is displayed on screen
        minNumBox.text = minNum.ToString(); 
        maxNumBox.text = maxNum.ToString(); 
        randomNumBox.text = randomNumber.ToString();
    }
    
    public void DisplayRandomNumber() //When we push the button we want to obtain a random number between the min and max value we have set, then we show that number on screen
    {
        randomNumber = Random.Range(minNum, maxNum + 1);
        randomNumBox.text = randomNumber.ToString();
    }

    public void IncreaseNumber(bool updatingMin) //on the up arrows we increase the min or max value of the random number
    {
        if(updatingMin)
        {
            minNum += 1;
            minNumBox.text = minNum.ToString();
        }
        else
        {
            maxNum += 1;
            maxNumBox.text = maxNum.ToString();
        }
    }
    public void DrecreaseNumber(bool updatingMin) //on the down arrows we decrease the min or max value of the random number
    {
        if (updatingMin)
        {
            minNum -= 1;
            minNumBox.text = minNum.ToString();
        }
        else
        {
            maxNum -= 1;
            maxNumBox.text = maxNum.ToString();
        }
    }
}
