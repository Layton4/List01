using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex7Alpha : MonoBehaviour
{
    public GameObject pokemon;
    public Slider alphaSlider;



    private void Start()
    {
        alphaSlider.value = pokemon.GetComponent<Renderer>().material.color.a; //When the playmode start the slider is put into the same value of the alpha of the object
    }

    public void ChangeAlphavalue(float value) //Everytime we change the value of the slider this method send the value to the alpha of the object, that's how we can controll it.
    {
        Color pokemonColour = pokemon.GetComponent<Renderer>().material.color;
        pokemonColour.a = value;
        pokemon.GetComponent<Renderer>().material.color = pokemonColour;
    }
}
