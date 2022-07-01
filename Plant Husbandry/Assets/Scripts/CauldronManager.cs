using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronManager : MonoBehaviour
{
    public CustomerOrderGenerator orderGenerator;
    
    public float heightWanted;
    public float heightAdded;


    public string eyeColourWanted;
    public string eyeColourAdded;

    public string hairColourWanted;
    public string hairColourAdded;

    public string personalityOneWanted;
    public string personalityOneAdded;

    public float personalityOneAmountWanted;
    public float personalityOneAmountAdded;

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
                personalityOneAmountWanted = 62.7f;
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
                personalityTwoAmountWanted = 62.7f;
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
}
