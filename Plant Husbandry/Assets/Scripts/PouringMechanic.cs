using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouringMechanic : MonoBehaviour
{
    public Slider beaker;
    public float beakerFull;
    public Image beakerCover;
    public bool pouring;
    public Animator beakerAnimator;
    public float fillSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        beakerCover.gameObject.SetActive(false);
        beaker.value = 0;
        pouring = true;
        fillSpeed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        beakerFull = beaker.value;
        
        if (Input.GetMouseButton(0) && pouring == true)
        {
            //every frame that mouse button is held the value will go up by the value of fillSpeed.
            beaker.value += fillSpeed;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            //Once mouse button is lifted other half of the cup will appear and will play animation. It will also turn the pouring bool off so that the player can't fill it up anymore by clicking.
            beakerCover.gameObject.SetActive(true);
            pouring=false;
            beakerAnimator.SetTrigger("Pouring");
        }

        


    }
}
