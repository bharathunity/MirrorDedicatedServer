using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Controls : NetworkBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If this is not a local player, return nothing.
        if(!isLocalPlayer)
            return;

        // Handle player inputs for the movement.

    }
}
