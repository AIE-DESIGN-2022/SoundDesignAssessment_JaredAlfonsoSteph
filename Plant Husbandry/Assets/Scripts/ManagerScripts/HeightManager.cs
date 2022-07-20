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

    private GameObject buttonObject;


    // Start is called before the first frame update
    void Start()
    {
        heightSlider.value = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        heightSlider.value = heightSelection;


        ActiveCheck();
        IncreaseHeight();
        LimitCheck();
        

    }

    

    void IncreaseHeight()
    {
        if (Input.GetMouseButton(0) && heightSelection <= heightLimit && increasing == true)
        {
            heightSelection += heightSpeed * Time.deltaTime * 5;
        }

        else if (Input.GetMouseButtonUp(0) && heightSelection >= 2)
        {

            Invoke("IncreasingFalse", 1f);
            //increasing = false;
            //Invoke("TurnOffHeight", 2.5f);
        }
    }

    void TurnOffHeight()
    {
        heightSliderParent.SetActive(false);
    }
    void ActiveCheck()
    {
        if (increasing == true)
        {
            Invoke("TurnOn", 0.1f);
            
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

    public void TurnOn()
    {
        heightSliderParent.SetActive(true);
        
    }

   public void IncreasingTrue(GameObject button)
   {
        //Invoke("TurnOn", 0.1f);
        increasing = true;
        buttonObject = button;
        buttonObject.SetActive(false);

    }

   void IncreasingFalse()
    {
        increasing = false;
    }

    public void ResetHeightManager()
    {
        buttonObject.SetActive(true);
        increasing = false;
        heightSelection = 0;
    }
}