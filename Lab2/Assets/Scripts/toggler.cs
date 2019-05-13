using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggler : MonoBehaviour
{
    bool toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    // Update is called once per frame
    void Update()
    {

        this.GetComponent<MeshRenderer>().enabled = toggle;


        if (Input.GetKeyDown("space"))
        {
            toggle = !toggle; 
        }
    }
}
