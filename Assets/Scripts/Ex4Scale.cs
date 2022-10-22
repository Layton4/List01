using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Ex4Scale : MonoBehaviour
{
    public GameObject sphere;
    public Slider scaleSlider;
    public Vector3 scaleVector;
    
    void Start()
    {
        scaleSlider.value = sphere.transform.localScale.x; //First update the slider with the value of scale that the sphere has when we start to play
    }

    public void ChangeScale() //This method called when the slider value changes save the value and put the number on the scale of the sphere to change it.
    {
        scaleVector.x = scaleSlider.value;
        scaleVector.y = scaleSlider.value;
        scaleVector.z = scaleSlider.value;

        sphere.transform.localScale = scaleVector;
    }
}
