using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex10Spheres : MonoBehaviour
{
    public TextMeshProUGUI ScoreText; //The TextBox where we show the score
    public int Score; //how many point we have in the game
    void Start()
    {
        Score = 0; //start with 0 points
        ScoreText.text = $"Score: {Score}";
    }

    public void ScorePoint(int points) //When we score we add 1 point to the score counter and update the Score text
    {
        Score += points;
        ScoreText.text = $"Score: {Score}";
    }

}
