using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrderGenerator : MonoBehaviour
{
    public string[] heights = new string[] { "Really Tall", "A Little Tall", "Average Height", "A Little Short", "Really Short" };
    public string currentHeight;
    int heightNumber;

    public string[] hairColour = new string[] { "Brown", "Black", "Blonde", "Orange", "Blue" };
    public string currentHairColour;
    int hairColourNumber;

    public string[] eyeColour = new string[] { "Brown", "Green", "Blue", "Grey", "Red" };
    public string currentEyeColour;
    int eyeColourNumber;

    public string[] personalityTraits = new string[] { "Energetic", "Kind", "Openminded", "Extraversion" };
    public string[] currentPersonalityTrait;

    public string[] energyLevel = new string[] {"very energetic", "a little energetic", "a little lazy", "very lazy"};


    public string[] kindLevel = new string[] {"very kind", "a little kind", "a little mean", "very mean" };
    public string[] openmindedLevel = new string[] {"very openminded", "a little openminded", "neutral minded", "a little closeminded", "very closeminded"};
    public string[] extraversionLevel = new string[] { "very extroverted", "a little extroverted", "an ambivert", "a little introverted", "very introverted" };




    // Start is called before the first frame update
    void Start()
    {
        GenerateOrder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateOrder()
    {
        heightNumber = Random.Range (0, heights.Length);
        currentHeight = heights[heightNumber];
        Debug.Log(currentHeight);

        hairColourNumber = Random.Range(0, hairColour.Length);
        currentHairColour = hairColour[hairColourNumber];
        Debug.Log(currentHairColour);

        eyeColourNumber = Random.Range(0, eyeColour.Length);
        currentEyeColour = eyeColour[eyeColourNumber];
        Debug.Log(currentEyeColour);
    }
}
