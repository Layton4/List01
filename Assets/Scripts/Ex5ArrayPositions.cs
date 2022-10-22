using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5ArrayPositions : MonoBehaviour
{
    public Vector3[] positionsArray; //Array with the positions where will spawn a Capsule
    public GameObject capsulePrefab; //Capsule that is going to be spawned
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) //pressing S
        {
            foreach(Vector3 pos in positionsArray)
            {
                Instantiate(capsulePrefab, pos,capsulePrefab.transform.rotation); //Instantiate a capsule foreach and in each position of the array
            }
        }
    }
}
