using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //transform .position =new Vector3 (0,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        //print ("hello");
        //print (transform .position );

        if (Input .GetKey (KeyCode.W))
        {
            transform .position =new Vector3 (transform .position .x,transform .position .y + 0.01f,0);
        }
        if (Input .GetKey (KeyCode.S))
        {
            transform .position =new Vector3 (transform .position .x,transform .position .y - 0.01f,0);
        }
        if (Input .GetKey (KeyCode.A))
        {
            transform .position =new Vector3 (transform .position .x - 0.01f,transform .position .y,0);
        }
        if (Input .GetKey (KeyCode.D))
        {
            transform .position =new Vector3 (transform .position .x + 0.01f,transform .position .y,0);
        }


        /*
        if(Input .GetKeyDown (KeyCode.S))
        {
            transform .position =new Vector3 (0,-2,0);
        }
        if(Input .GetKeyDown (KeyCode.A))
        {
            transform .position =new Vector3 (-2,0,0);
        }
        if(Input .GetKeyDown (KeyCode.D))
        {
            transform.position =new Vector3 (2,0,0);
        }
        */




    }
}
