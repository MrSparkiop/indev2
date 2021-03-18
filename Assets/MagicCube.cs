using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCube : MonoBehaviour
{
    int numberOfTimes = 5;
    string nameOfTheKey = "ENTER";
    float speedOfBreaking = 6.94f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Ако Цъкнеш бутона W ще скочиш");
       // Debug.Log("Ако Цъкнеш бутона "+ numberOfTimes + " ще се преместиш напред");

        // Debug.LogWarning("Ако натиснеш бутона "+ nameOfTheKey + " нищо няма да се случи");
        // Debug.LogError("If you smash the keyboard at a speed of "+ speedOfBreaking +" nothing happens, you just cry");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Righ Arrow key was pressed");
        }
    }
}
