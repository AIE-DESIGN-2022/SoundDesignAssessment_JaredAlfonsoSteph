using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouringMechanic : MonoBehaviour
{
    public Slider beaker;
    public float beakerFull;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beakerFull = beaker.value;
        
        if (Input.GetMouseButton(0))
        {
            beaker.value += 0.2f;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("let go");
        }


    }
}
