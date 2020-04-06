using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //grab current position - assign new position
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
