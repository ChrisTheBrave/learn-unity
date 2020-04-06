using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if space key pressed down
        //print message

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("space key");
        }

        //if e key held down
        //print message

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }

        //if f key is lifted up
        //print f

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Key up on F");
        }
        
    }
}
