using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour
{
    //Script that handles input from two players
    //Player 1 => Controls left bat with W/S keys
    //Plater 2 => Controls right bat with arrow keys

    public GameObject leftBat;
    public GameObject rightBat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Default speed of the bat to zero on ever frame
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        //If the player is pressing the W key...
        if (Input.GetKey(KeyCode.W))
        {
            //Move the bat up
            //Debug.Log("Player 1 is pressing W");

            //Set the velocity to go up 1
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 20f, 0f);
        }

        //If the player is pressing the S key...
        else if (Input.GetKey(KeyCode.S))
        {
            //Move the bat down
            //Debug.Log("Player 1 is pressing S");

            //Set the velocity to go down 1
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -20f, 0f);
        }

        //Default speed of the bat to zero on ever frame
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        //If the player is pressing the UpArrow key...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the bat up
            //Debug.Log("Player 1 is pressing W");

            //Set the velocity to go up 1
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 20f, 0f);
        }

        //If the player is pressing the DownArrow key...
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the bat down
            //Debug.Log("Player 1 is pressing S");

            //Set the velocity to go down 1
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -20f, 0f);
        }

        //If you arent pressing either of the keys, velocity will stay at 0.
    }
}
