using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouringMechanic : MonoBehaviour
{
    public Slider beaker;
    public float beakerFull;
    public Image beakerCover;
    bool pouring;
    public Animator beakerAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        beakerCover.gameObject.SetActive(false);
        beaker.value = 0;
        pouring = true;
    }

    // Update is called once per frame
    void Update()
    {
        beakerFull = beaker.value;
        
        if (Input.GetMouseButton(0) && pouring == true)
        {
            beaker.value += 0.2f;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            beakerCover.gameObject.SetActive(true);
            pouring=false;
            beakerAnimator.SetTrigger("Pouring");
        }

        


    }
}
