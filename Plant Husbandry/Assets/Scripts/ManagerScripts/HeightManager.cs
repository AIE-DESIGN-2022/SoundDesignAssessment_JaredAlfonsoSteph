using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightManager : MonoBehaviour
{

    public Slider heightSlider;

    public GameObject heightSliderParent;

    public bool increasing;

    public float heightSelection;
    public float heightSpeed;
    public float heightLimit;


    // Start is called before the first frame update
    void Start()
    {
        heightSlider.value = 0;
        increasing = false;

    }

    // Update is called once per frame
    void Update()
    {
        heightSlider.value = heightSelection;


        ActiveCheck();
        IncreaseHeight();
        LimitCheck();
        

    }

    void TurnOffHeight()
    {
        heightSliderParent.SetActive(false);
    }

    void IncreaseHeight()
    {
        if (Input.GetMouseButton(0) && heightSelection <= heightLimit && increasing == true)
        {
            heightSelection += heightSpeed * Time.deltaTime * 5;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            increasing = false;
            Invoke("TurnOffHeight", 2.5f);
        }
    }

    void ActiveCheck()
    {
        if (increasing == true)
        {
            Invoke("TurnOn", 0.5f);
            
        }

        else if (increasing == false)
        {
            Invoke("TurnOffHeight", 1.5f);
        }
    }

    void LimitCheck()
    {
        if (heightSelection >= heightLimit)
        {
            increasing = false;
            Invoke("TurnOffHeight", 2.5f);
        }
    }

    void TurnOn()
    {
        heightSliderParent.SetActive(true);
    }


}