using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    public GameObject player;
    bool Crouching = false;
    bool Jumping = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w"))
        {
            Jumping = true;
        }

        if (Input.GetKeyDown("s"))
        {
            Crouching = true;
        }

        if (Input.GetKeyUp("w"))
        {
            Jumping = false;
        }

        if (Input.GetKeyUp("s"))
        {
            Crouching = false;
        }

        if (Input.GetKeyDown("a") && Input.GetKeyDown("d"))
        {
            //Wow such empty
        }
        else if (Input.GetKey("a"))
        {
            player.GetComponent<CharacterController2D>().Move(-0.5f, Crouching, Jumping);
        }
        else if (Input.GetKey("d"))
        {
            player.GetComponent<CharacterController2D>().Move(0.5f, Crouching, Jumping);
        }
        else
        {
            player.GetComponent<CharacterController2D>().Move(0f, Crouching, Jumping);
        }
    }
}
