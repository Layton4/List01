using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex9Light : MonoBehaviour
{
    public Light bulb;
    public Toggle onSwitch;
    public void TurnItOn()
    {
        bulb.enabled = onSwitch.isOn;
    }
}
