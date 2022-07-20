using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{


    public bool canvasActive;

    public GameObject mixingStationCanvas;
    public GameObject pot1;
    public GameObject pot2;
    public GameObject pot3;

    // Start is called before the first frame update
    void Start()
    {
        canvasActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasActive == true)
        {
            mixingStationCanvas.SetActive(true);
            pot1.SetActive(true);
            pot2.SetActive(true);
            pot3.SetActive(true);
        }

        else if(canvasActive == false)
        {
            mixingStationCanvas.SetActive(false);
            pot1.SetActive(false);
            pot2.SetActive(false);
            pot3.SetActive(false);
        }
    }

    public void TurnOn()
    {
        canvasActive = true;
    }

    public void TurnOff()
    {
        canvasActive = false;
    }
}
