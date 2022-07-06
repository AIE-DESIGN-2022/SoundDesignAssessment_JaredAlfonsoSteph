using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouringMechanic : MonoBehaviour
{
    public Slider beaker;
    public Image beakerCover;

    public GameObject beakerImage;

    public bool pouring;

    public Animator beakerAnimator;

    public float beakerFull;
    public float fillSpeed;

    // Start is called before the first frame update
    void Start()
    {
        beakerImage.SetActive(false);
        beakerCover.gameObject.SetActive(false);
        beaker.value = 0;
        pouring = false;
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

        else if (Input.GetMouseButtonUp(0) && pouring == true)
        {
            //Once mouse button is lifted other half of the cup will appear and will play animation. It will also turn the pouring bool off so that the player can't fill it up anymore by clicking.
            beakerCover.gameObject.SetActive(true);
            pouring = false;
            beakerAnimator.SetTrigger("Pouring");
        }

    }

    public void PourMechanic()
    {

        beakerImage.SetActive(true);
        Invoke("WaitForJug", 1f);

    }
    void WaitForJug()
    {
        pouring = true;
    }


}
