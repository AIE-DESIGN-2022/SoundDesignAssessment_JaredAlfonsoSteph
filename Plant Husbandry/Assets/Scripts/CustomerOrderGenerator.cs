using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerOrderGenerator : MonoBehaviour
{
    public string[] heights = new string[] { "really tall", "a little tall", "average height", "a little short", "really short" };
    public string currentHeight;
    int heightNumber;

    public string[] hairColour = new string[] { "brown", "black", "blonde", "orange", "blue" };
    public string currentHairColour;
    int hairColourNumber;

    public string[] eyeColour = new string[] { "brown", "green", "blue", "grey", "red" };
    public string currentEyeColour;
    int eyeColourNumber;

    public string[] personalityTraits = new string[] { "energetic", "kind", "openminded", "extraversion" };
    public string currentPersonalityTraitOne;
    int personalityTraitOneNumber;
    public string currentPersonalityTraitTwo;
    int personalityTraitTwoNumber;

    public string[] energyLevel = new string[] {"very energetic", "a little energetic", "a little lazy", "very lazy"};


    public string[] kindLevel = new string[] {"very kind", "a little kind", "a little mean", "very mean" };
    public string[] openmindedLevel = new string[] {"very openminded", "a little openminded", "neutral minded", "a little closeminded", "very closeminded"};
    public string[] extraversionLevel = new string[] { "very extroverted", "a little extroverted", "an ambivert", "a little introverted", "very introverted" };

    public TextMeshProUGUI customerOrderText;


    // Start is called before the first frame update
    void Start()
    {
        GeneratePhysicalAttributes();
        GeneratePersonalityTraits();
        GenerateCustomerText();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        customerOrderText.text = "Hi! I'm looking for someone who is " + currentHeight + " with " + currentHairColour + " hair and " + currentEyeColour + " eyes  and a ####### personality.";
    }

    public void GeneratePersonalityTraits()
    {
        personalityTraitOneNumber = Random.Range(0, personalityTraits.Length);

        personalityTraitTwoNumber = Random.Range(0, personalityTraits.Length);
        

        if (personalityTraitTwoNumber == personalityTraitOneNumber)
        {
            Debug.Log("they match");

            GeneratePersonalityTraits();
        }

        currentPersonalityTraitOne = personalityTraits[personalityTraitOneNumber];

        currentPersonalityTraitTwo = personalityTraits[personalityTraitTwoNumber];


    }


}
