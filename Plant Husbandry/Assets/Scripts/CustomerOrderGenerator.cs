using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerOrderGenerator : MonoBehaviour
{
    [Header("Heights")]
    public string[] heights = new string[] { "really tall", "a little tall", "average height", "a little short", "really short" };
    public string currentHeight;
    public int heightNumber;

    [Header("Hair")]
    public string[] hairColour = new string[] { "brown", "black", "blonde", "orange", "blue" };
    public string currentHairColour;
    int hairColourNumber;

    [Header("Eyes")]
    public string[] eyeColour = new string[] { "brown", "green", "blue", "grey", "red" };
    public string currentEyeColour;
    int eyeColourNumber;

    [Header("PersonalityTraits")]
    public string[] personalityTraits = new string[] { "energetic", "kind", "openminded", "extroversion" };
    public string currentPersonalityTraitOne;
    public int personalityTraitOneNumber;
    public string currentPersonalityTraitTwo;
    public int personalityTraitTwoNumber;

    [Header("energy")]
    public string[] energyLevel = new string[] {"very energetic", "a little energetic", "a little lazy", "very lazy"};
    public string currentEnergyLevel;
    int energyLevelNumber;

    [Header("Kind")]
    public string[] kindLevel = new string[] {"very kind", "a little kind", "a little mean", "very mean" };
    public string currentKindLevel;
    int kindLevelNumber;

    [Header("Openminded")]
    public string[] openmindedLevel = new string[] {"very openminded", "a little openminded", "neutral minded", "a little closeminded", "very closeminded"};
    public string currentOpenmindedLevel;
    int openmindedLevelNumber;

    [Header("Extroversion")]
    public string[] extroversionLevel = new string[] { "very extroverted", "a little extroverted", "an ambivert", "a little introverted", "very introverted" };
    public string currentExtroversionLevel;
    int extroversionLevelNumber;

    [Header("Personality Output")]
    public string currentPersonalityTraitOneLevel;

    public string currentPersonalityTraitTwoLevel;

    public int personalityOneArrayLength;

    public int personalityTwoArrayLength;

    public TextMeshProUGUI customerOrderText;

    [Header("OrderTicketUI")]
    public TextMeshProUGUI customerNameText;
    public TextMeshProUGUI heightText;
    public TextMeshProUGUI hairColourText;
    public TextMeshProUGUI eyeColourText;
    public TextMeshProUGUI personalityOneText;
    public TextMeshProUGUI personalityTwoText;

    public CustomerNameGenerator customerNameGenerator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateOrder()
    {
        GeneratePhysicalAttributes();
        GeneratePersonalityTraits();
        GeneratePersonalityLevel();
        GenerateCustomerText();
    }

    public void GeneratePhysicalAttributes()
    {
        heightNumber = Random.Range (0, heights.Length);
        currentHeight = heights[heightNumber];

        hairColourNumber = Random.Range(0, hairColour.Length);
        currentHairColour = hairColour[hairColourNumber];

        eyeColourNumber = Random.Range(0, eyeColour.Length);
        currentEyeColour = eyeColour[eyeColourNumber];


    }

    public void GenerateCustomerText()
    {
        customerOrderText.text = "Hi! I'm looking for someone who is " + currentHeight + " with " + currentHairColour + " hair and " + currentEyeColour + " eyes. I also want their personality to be " + currentPersonalityTraitOneLevel + " and " + currentPersonalityTraitTwoLevel + ".";

        
        heightText.text = "- " + currentHeight;
        hairColourText.text = "- " + currentHairColour + " hair";
        eyeColourText.text = "- " + currentEyeColour + " eyes";
        personalityOneText.text = "- " + currentPersonalityTraitOneLevel;
        personalityTwoText.text = "- " + currentPersonalityTraitTwoLevel;
        


    }

    public void GeneratePersonalityTraits()
    {
        personalityTraitOneNumber = Random.Range(0, personalityTraits.Length);

        personalityTraitTwoNumber = Random.Range(0, personalityTraits.Length);
        

        if (personalityTraitTwoNumber == personalityTraitOneNumber)
        {
            //Debug.Log("they match");

            GeneratePersonalityTraits();
        }

        currentPersonalityTraitOne = personalityTraits[personalityTraitOneNumber];

        currentPersonalityTraitTwo = personalityTraits[personalityTraitTwoNumber];

        
    }

    public void GeneratePersonalityLevel()
    {
        if (currentPersonalityTraitOne == "energetic")
        {
            energyLevelNumber = Random.Range(0, energyLevel.Length);
            currentPersonalityTraitOneLevel = energyLevel[energyLevelNumber];
            personalityOneArrayLength = energyLevel.Length;
           // Debug.Log("energy one");
        }
        if (currentPersonalityTraitOne == "kind")
        {
            kindLevelNumber = Random.Range(0, kindLevel.Length);
            currentPersonalityTraitOneLevel = kindLevel[kindLevelNumber];
            personalityOneArrayLength = kindLevel.Length;

            // Debug.Log("kind one");
        }
        if (currentPersonalityTraitOne == "openminded")
        {
            openmindedLevelNumber = Random.Range(0, openmindedLevel.Length);
            currentPersonalityTraitOneLevel = openmindedLevel[openmindedLevelNumber];
            personalityOneArrayLength = openmindedLevel.Length;
            // Debug.Log("openminded one");
        }
        if (currentPersonalityTraitOne == "extroversion")
        {
            extroversionLevelNumber = Random.Range(0, extroversionLevel.Length);
            currentPersonalityTraitOneLevel = extroversionLevel[extroversionLevelNumber];
            personalityOneArrayLength = extroversionLevel.Length;

            // Debug.Log("extroversion one");
        }

        if (currentPersonalityTraitTwo == "energetic")
        {
            energyLevelNumber = Random.Range(0, energyLevel.Length);
            currentPersonalityTraitTwoLevel = energyLevel[energyLevelNumber];
            personalityTwoArrayLength = energyLevel.Length;
            // Debug.Log("energetic two");
        }
        if (currentPersonalityTraitTwo == "kind")
        {
            kindLevelNumber = Random.Range(0, kindLevel.Length);
            currentPersonalityTraitTwoLevel = kindLevel[kindLevelNumber];
            personalityTwoArrayLength = kindLevel.Length;
            //  Debug.Log("kind two");
        }
        if (currentPersonalityTraitTwo == "openminded")
        {
            openmindedLevelNumber = Random.Range(0, openmindedLevel.Length);
            currentPersonalityTraitTwoLevel = openmindedLevel[openmindedLevelNumber];
            personalityTwoArrayLength = openmindedLevel.Length;
            // Debug.Log("openminded two");
        }
        if (currentPersonalityTraitTwo == "extroversion")
        {
            extroversionLevelNumber = Random.Range(0, extroversionLevel.Length);
            currentPersonalityTraitTwoLevel = extroversionLevel[extroversionLevelNumber];
            personalityTwoArrayLength = extroversionLevel.Length;

            //Debug.Log("extroversion two");
        }
    }


}
