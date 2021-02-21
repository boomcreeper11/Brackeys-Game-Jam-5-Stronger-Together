using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager2 : MonoBehaviour
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

        if (Input.GetKeyDown("up")) 
        {
            Jumping = true;
        }

        if (Input.GetKeyDown("down"))
        {
            Crouching = true;
        }

        if (Input.GetKeyUp("up"))
        {
            Jumping = false;
        }

        if (Input.GetKeyUp("down"))
        {
            Crouching = false;
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right"))
        {
            //Wow such empty
        } 
        else if (Input.GetKey("left"))
		{
            player.GetComponent<CharacterController2D>().Move(-0.5f, Crouching, Jumping);
        } 
        else if (Input.GetKey("right"))
		{
            player.GetComponent<CharacterController2D>().Move(0.5f, Crouching, Jumping);
        }
        else
		{
            player.GetComponent<CharacterController2D>().Move(0f, Crouching, Jumping);
        }

    }
}
