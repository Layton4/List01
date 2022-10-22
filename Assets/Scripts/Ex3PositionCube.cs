using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3PositionCube : MonoBehaviour
{
    public GameObject cube; //the cube we will move though the scene to random positions
    private Vector3 position;

    private float sideWall = 8.35f; //the border of the screen from the xAxis
    private float upDownWall = 4.5f; //the border of the screen from the YAxis
    void Start()
    {
        cube.transform.position = GetRandomPosition(); //First when we start to play we move the cube to its first random position
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)) //When we press the enter button the cube is teleported to a new random position
        {
            cube.transform.position = GetRandomPosition();
        }
    }

    public Vector3 GetRandomPosition() //this method return a random position in the range of coordinates inside the screen
    {
        position.x = Random.Range(-sideWall, sideWall);
        position.y = Random.Range(-upDownWall, upDownWall);

        return position;
    }
}
