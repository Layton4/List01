using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex9Light : MonoBehaviour
{
    public Light bulb; //Point light
    public Toggle onSwitch; //the toggle

    public TextMeshProUGUI lightInfoText;

    private void Start()
    {
        TurnItOn();
    }
    public void TurnItOn()
    {
        bulb.enabled = onSwitch.isOn; //The Toggle controles the light turning it on or off.

        if(bulb.enabled == true)
        {
            lightInfoText.text = "Light is On";
        }
        else
        {
            lightInfoText.text = "Light is Off";
        }
    }
}
