using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private Ex10Spheres Ex10Script;
    private int sphereValue = 1;
    private void Start()
    {
        Ex10Script = FindObjectOfType<Ex10Spheres>();
    }
    private void OnMouseDown() //When we click on a sphere we add one point before destroying it
    {
        Ex10Script.ScorePoint(sphereValue);
        Destroy(gameObject);
    }
}
