using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantGrowTimer : MonoBehaviour
{
    public GameObject PlantCharacter;

    public float secondsLeft;
    public bool timerOn = true;

    public float maxTime;

    public TextMeshProUGUI timerText;

    public float maxHeightAdded;

    public float growTime;

    public float timerPercentageStageOne;
    private float timeStageOne;

    public float timerPercentageStageTwo;
    private float timeStageTwo;

    public float timerPercentageStageThree;
    private float timeStageThree;

    public GameObject fertilizerButton;

    public GameObject plantReadyButton;

    public GameObject popUpUI;
    public TextMeshProUGUI questionText;
    public GameObject plantCharacter;
    public Renderer plantCharacterEye1;
    public Renderer plantCharacterEye2;
    public Renderer plantCharacterHair;

    public TextMeshProUGUI costText;

    public GameObject plantSeedButton;

    public int costToPlant;
    public int costToBurn;

    public TextMeshProUGUI costToBurnText;

    public MoneyManager moneyManager;

    public GameObject noMoneyText;

    [Header("EyeMaterials")]
    public Material blueEyeMaterial;
    public Material brownEyeMaterial;
    public Material defaultEyeMaterial;
    public Material greenEyeMaterial;
    public Material redEyeMaterial;
    public Material yellowEyeMaterial;

    [Header("HairMaterials")]
    public Material blackHairMaterial;
    public Material blondeHairMaterial;
    public Material blueHairMaterial;
    public Material brownHairMaterial;
    public Material defaultHairMaterial;
    public Material orangeHairMaterial;

    public CustomerOrderManager customerOrderManager;


    // Start is called before the first frame update
    void Start()
    {
        timeStageOne = secondsLeft * (timerPercentageStageOne/100);
        timeStageTwo = secondsLeft * (timerPercentageStageTwo / 100);
        timeStageThree = secondsLeft * (timerPercentageStageThree / 100);
        PlantCharacter.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        timerOn = false;

        plantSeedButton.SetActive(true);

        plantReadyButton.SetActive(false);

        fertilizerButton.SetActive(false);

        popUpUI.SetActive(false);

        //costText.SetActive(false);

        plantCharacter.SetActive(false);

        costText.text = "- $" + costToPlant;

        secondsLeft = maxTime;

        noMoneyText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            secondsLeft -= Time.deltaTime;
            UpdateTimer(secondsLeft);
        }     

        if(secondsLeft <= timeStageThree)
        {
           // Debug.Log("Stage Three");
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(1f, maxHeightAdded, 1f), Time.deltaTime * growTime);

        }   
        else if(secondsLeft <= timeStageTwo)
        {
           // Debug.Log("Stage Two");
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(0.6f, 0.6f, 0.6f), Time.deltaTime * growTime);


        }
        else if (secondsLeft <= timeStageOne)
        {
           // Debug.Log("Stage One");
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(0.3f, 0.3f, 0.3f), Time.deltaTime * growTime);
        }

        if(secondsLeft <= 0)
        {
            secondsLeft = 0;
            timerOn = false;
            plantReadyButton.SetActive(true);
        }
    }
    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void AddFertilizer()
    {
        timerOn = true;
        fertilizerButton.SetActive(false);

        costText.text = " ";

        noMoneyText.SetActive(false);


        SetHairEyeColour();


        //plantCharacterEye1.material = 
    }

    public void SellPlant()
    {
        popUpUI.SetActive(true);
        questionText.text = "Sell Plant-Husband";

        costToBurnText.text = "- $" + costToBurn;

        secondsLeft = maxTime;

        noMoneyText.SetActive(false);
    }

    public void YesSell()
    {
        //
        plantCharacter.SetActive(false);
        popUpUI.SetActive(false);

        Debug.Log("Sell Plant");

        ResetPlantPot();

        noMoneyText.SetActive(false);

    }

    public void NoSell()
    {


        if ((moneyManager.currentMoney - costToBurn) < 0)
        {
            //you dont have enough money for that
            Debug.Log("you don't have enough money for that");
            noMoneyText.SetActive(true);
        }
        else
        {
            //???
            Debug.Log("No Sell Plant");

            plantCharacter.SetActive(false);

            //costText.text = "- $" + costToBurn;

            moneyManager.DecreaseMoney(costToBurn);

            ResetPlantPot();

            noMoneyText.SetActive(false);
        }
    }

    public void ResetPlantPot()
    {
        timerOn = false;

        plantSeedButton.SetActive(true);

        plantReadyButton.SetActive(false);

        fertilizerButton.SetActive(false);

        popUpUI.SetActive(false);

        //costText.SetActive(false);

        plantCharacter.SetActive(false);

        costText.text = "- $" + costToPlant;
        noMoneyText.SetActive(false);

        ResetHairEyeColour();
    }

    public void PlantSeed()
    {
        

        if ((moneyManager.currentMoney - costToPlant) < 0)
        {
            //show warning text
            Debug.Log("you don't have enough money for that");
            noMoneyText.SetActive(true);
        }
        else
        {
            //AddFertilizer();

            plantCharacter.SetActive(true);
            fertilizerButton.SetActive(true);
            plantSeedButton.SetActive(false);
            PlantCharacter.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            timerOn = false;

            costText.text = " ";

            moneyManager.DecreaseMoney(costToPlant);

            noMoneyText.SetActive(false);

            
        }
           


    }

    public void SetHairEyeColour()
    {
        if (customerOrderManager.eyeColourAdded == "brown")
        {
            plantCharacterEye1.material = brownEyeMaterial;
            plantCharacterEye2.material = brownEyeMaterial;
        }
        if (customerOrderManager.eyeColourAdded == "green")
        {
            plantCharacterEye1.material = greenEyeMaterial;
            plantCharacterEye2.material = greenEyeMaterial;
        }
        if (customerOrderManager.eyeColourAdded == "blue")
        {
            plantCharacterEye1.material = blueEyeMaterial;
            plantCharacterEye2.material = blueEyeMaterial;
        }
        if (customerOrderManager.eyeColourAdded == "yellow")
        {
            plantCharacterEye1.material = yellowEyeMaterial;
            plantCharacterEye2.material = yellowEyeMaterial;
        }
        if (customerOrderManager.eyeColourAdded == "red")
        {
            plantCharacterEye1.material = redEyeMaterial;
            plantCharacterEye2.material = redEyeMaterial;
        }

        if (customerOrderManager.hairColourAdded == "brown")
        {
            plantCharacterHair.material = brownHairMaterial;
        }
        if (customerOrderManager.hairColourAdded == "black")
        {
            plantCharacterHair.material = blackHairMaterial;
        }
        if (customerOrderManager.hairColourAdded == "blonde")
        {
            plantCharacterHair.material = blondeHairMaterial;
        }
        if (customerOrderManager.hairColourAdded == "orange")
        {
            plantCharacterHair.material = orangeHairMaterial;
        }
        if (customerOrderManager.hairColourAdded == "blue")
        {
            plantCharacterHair.material = blueHairMaterial;
        }

    }

    public void ResetHairEyeColour()
    {
        plantCharacterEye1.material = defaultEyeMaterial;
        plantCharacterEye2.material = defaultEyeMaterial;
        plantCharacterHair.material = defaultHairMaterial;
    }
}
