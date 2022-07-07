using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrderManager : MonoBehaviour
{
    public CustomerOrderGenerator orderGenerator;
    
    [Header("Height")]
    public float heightWanted;
    public float heightAdded;

    [Header("Eyes")]
    public string eyeColourWanted;
    public string eyeColourAdded;

    public ButtonManager eyeButtonManager;

    [Header("Hair")]
    public string hairColourWanted;
    public string hairColourAdded;

    [Header("Personality One")]
    public string personalityOneWanted;
    public string personalityOneAdded;

    public float personalityOneAmountWanted;
    public float personalityOneAmountAdded;

    [Header("Personality two")]
    public string personalityTwoWanted;
    public string personalityTwoAdded;

    public float personalityTwoAmountWanted;
    public float personalityTwoAmountAdded;

    //float numberToCalculated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eyeColourWanted = orderGenerator.currentEyeColour;
        hairColourWanted = orderGenerator.currentHairColour;
        personalityOneWanted = orderGenerator.currentPersonalityTraitOne;
        personalityTwoWanted = orderGenerator.currentPersonalityTraitTwo;


        //heightWanted = orderGenerator.heightNumber;

        HeightPercentageWanted(orderGenerator.heightNumber, orderGenerator.heights.Length);
        PersonalityOnePercentageWanted(orderGenerator.personalityTraitOneNumber, orderGenerator.personalityOneArrayLength);
        PersonalityTwoPercentageWanted(orderGenerator.personalityTraitTwoNumber, orderGenerator.personalityTwoArrayLength);

        
    }

    public void HeightPercentageWanted(int numberToCalculate, int arrayLength)
    {
        if(arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                heightWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                heightWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                heightWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                heightWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                heightWanted = 10f;
            }
        }



    }

    public void PersonalityOnePercentageWanted(int numberToCalculate, int arrayLength)
    {

        if (arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                personalityOneAmountWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                personalityOneAmountWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                personalityOneAmountWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                personalityOneAmountWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                personalityOneAmountWanted = 10f;
            }
        }
 

        if (arrayLength == 4)
        {
            if (numberToCalculate == 0)
            {
                personalityOneAmountWanted = 87.5f;
            }
            if (numberToCalculate == 1)
            {
                personalityOneAmountWanted = 62.5f;
            }
            if (numberToCalculate == 2)
            {
                personalityOneAmountWanted = 37.5f;
            }
            if (numberToCalculate == 3)
            {
                personalityOneAmountWanted = 12.5f;
            }
        }
    }

    public void PersonalityTwoPercentageWanted(int numberToCalculate, int arrayLength)
    {

        if(arrayLength == 5)
        {
            if (numberToCalculate == 0)
            {
                personalityTwoAmountWanted = 90f;
            }
            if (numberToCalculate == 1)
            {
                personalityTwoAmountWanted = 70f;
            }
            if (numberToCalculate == 2)
            {
                personalityTwoAmountWanted = 50f;
            }
            if (numberToCalculate == 3)
            {
                personalityTwoAmountWanted = 30f;
            }
            if (numberToCalculate == 4)
            {
                personalityTwoAmountWanted = 10f;
            }
        }

        if (arrayLength == 4)
        {
            if (numberToCalculate == 0)
            {
                personalityTwoAmountWanted = 87.5f;
            }
            if (numberToCalculate == 1)
            {
                personalityTwoAmountWanted = 62.5f;
            }
            if (numberToCalculate == 2)
            {
                personalityTwoAmountWanted = 37.5f;
            }
            if (numberToCalculate == 3)
            {
                personalityTwoAmountWanted = 12.5f;
            }
        }

    }

    public void CompareWantedAdded()
    {
        if (heightAdded >= (heightWanted - 10) && heightAdded <= (heightWanted + 10))
        {
            Debug.Log("height is within range");
        }


        if (eyeColourAdded == eyeColourWanted)
        {
            Debug.Log("Right eye colour");
        }

        if (hairColourAdded == hairColourWanted)
        {
            Debug.Log("Right hair colour");
        }

        if (personalityOneAdded == personalityOneWanted)
        {
            Debug.Log("right personality one added");
        }

        if (personalityTwoAdded == personalityTwoWanted)
        {
            Debug.Log("right personality two added");
        }

       // if()

    }
}
