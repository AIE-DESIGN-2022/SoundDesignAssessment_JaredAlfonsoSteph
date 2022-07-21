using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightManagerGrabbable : MonoBehaviour
{

    public Slider heightSlider;

    public GameObject acceptButton;

    public GameObject heightSliderParent;

    public bool sliderActive;

    
    public float heightSelection;
    
    
    // Start is called before the first frame update
    void Start()
    {
        heightSliderParent.SetActive(false);
        sliderActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        heightSelection = heightSlider.value;

        

    }

    
    public void TurnOff()
    {
        heightSliderParent.SetActive(false);
        acceptButton.SetActive(false);
        
    }

    public void TurnOn()
    {
        
        if(sliderActive == false)
        {
            heightSliderParent.SetActive(true);
            sliderActive=true;
        }
        
        
    }

    public void ResetHeightManager()
    {
        acceptButton.SetActive(true);
        heightSlider.value = 0;
        heightSelection = 0;
        sliderActive= false;

    }
}
