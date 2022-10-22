using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6Dropdown : MonoBehaviour
{
    public Material[] colours; //The colour options of the dropdown

    public GameObject colouredObject; //The object that it will be painted
    void Start()
    {
        DropdownSelection(0);
    }
    public void DropdownSelection(int selection) //When we select an option of the dropdown we paint the cilinder with the colour selected
    {
        colouredObject.GetComponent<Renderer>().material = colours[selection];
    }
}
