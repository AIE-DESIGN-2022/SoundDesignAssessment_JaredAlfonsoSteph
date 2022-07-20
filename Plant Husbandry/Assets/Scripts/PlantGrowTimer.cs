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
    public DateManager dateManager;

    [Header("SuccessScore")]
    public int dateQuality;
    public int customerFinalPayment;

    //public TextMeshProUGUI sellPlantText;
    public TextMeshProUGUI orderInfoText;

    [Header("AddedPlantAttributes")]

    public string firstName;
    public string lastName;
    public string plantName;

    public float height;

    public string eyeColour;

    public string hairColour;


    public string personalityOne;

    public float personalityOneAmount;

    public string personalityTwo;

    public float personalityTwoAmount;

    public OrderAcceptanceScript orderAcceptance;
    public PotAudioManager potAudio;

    private bool stageOneSoundPlayed;
    private bool stageTwoSoundPlayed;
    private bool stageThreeSoundPlayed;
    private bool plantReadySoundPlayed;
    

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
            if (!stageOneSoundPlayed)
            {
                potAudio.PlantGrowAudio();
                stageOneSoundPlayed = true;
            }
            

        }   
        else if(secondsLeft <= timeStageTwo)
        {
            // Debug.Log("Stage Two");
            if (!stageTwoSoundPlayed)
            {
                potAudio.PlantGrowAudio();
                stageTwoSoundPlayed = true;
            }
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(0.6f, 0.6f, 0.6f), Time.deltaTime * growTime);
            

        }
        else if (secondsLeft <= timeStageOne)
        {
            // Debug.Log("Stage One");
            if (!stageThreeSoundPlayed)
            {
                potAudio.PlantGrowAudio();
                stageThreeSoundPlayed = true;
            }
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(0.3f, 0.3f, 0.3f), Time.deltaTime * growTime);
            
        }

        

        if(secondsLeft <= 0)
        {
            secondsLeft = 0;
            timerOn = false;
            plantReadyButton.SetActive(true);

            if (!plantReadySoundPlayed)
            {
                potAudio.PlantReadyAudio();
                plantReadySoundPlayed = true;
            }
           
        }

        if (popUpUI.activeInHierarchy == true)
        {
            orderInfoText.text = "Complete Order No. " + customerOrderManager.orderNumber + " for " + customerOrderManager.firstName + " " + customerOrderManager.lastName;
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

        height = customerOrderManager.heightAdded;
        eyeColour = customerOrderManager.eyeColourAdded;
        hairColour = customerOrderManager.hairColourAdded;
        personalityOne = customerOrderManager.personalityOneAdded;
        personalityOneAmount = customerOrderManager.personalityOneAmountAdded;
        personalityTwo = customerOrderManager.personalityTwoAdded;
        personalityTwoAmount = customerOrderManager.personalityTwoAmountAdded;

        //plantCharacterEye1.material = 

        customerOrderManager.ResetOrderManager();

        orderAcceptance.OrderPopUp();

        potAudio.AddFertilizerAudio();
    }

    public void SellPlant()
    {
        popUpUI.SetActive(true);
        questionText.text = "Sell Plant-Husband";

        costToBurnText.text = "- $" + costToBurn;

        secondsLeft = maxTime;

        noMoneyText.SetActive(false);
        potAudio.PotButtonClick();

    }

    public void YesSell()
    {
        //
        plantCharacter.SetActive(false);
        popUpUI.SetActive(false);

        Debug.Log("Sell Plant");

        //ResetPlantPot();

        noMoneyText.SetActive(false);

        
        CompareWantedAdded();
        CalculateReward();

        //dateManager.

        //firstName = 

        dateManager.thisDateQuality = dateQuality;
        dateManager.thisCustomerFinalPayment = customerFinalPayment;
        dateManager.thisFirstName = customerOrderManager.firstName;
        dateManager.thisLastName = customerOrderManager.lastName;
        dateManager.thisPlantName = customerOrderManager.plantName;
        dateManager.thisHairColour = hairColour;
        dateManager.thisEyeColour = eyeColour;

        dateManager.DateReview();

        ResetPlantPot();
        potAudio.PotButtonClick();
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

            potAudio.PotButtonClick();
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

        stageOneSoundPlayed = false;
        stageTwoSoundPlayed = false;
        stageThreeSoundPlayed = false;
        plantReadySoundPlayed = false;
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

            //ResetHairEyeColour = 
            potAudio.PotButtonClick();
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

    public void CompareWantedAdded()
    {
        //if(qualityCalculated == false)
        //{
        if (height >= (customerOrderManager.heightWanted - 10) && height <= (customerOrderManager.heightWanted + 10))
        {
            Debug.Log("height is within range");

            dateQuality += 10;
        }
        else
        {
            Debug.Log("Wrongheigt");
        }


        if (eyeColour == customerOrderManager.eyeColourWanted)
        {
            Debug.Log("Right eye colour");
            dateQuality += 10;
        }
        else
        {
            Debug.Log("Wrong personality");

        }

        if (hairColour == customerOrderManager.hairColourWanted)
        {
            Debug.Log("Right hair colour");
            dateQuality += 10;
        }
        else
        {
            Debug.Log("Wrong hair");
        }

        if (personalityOne == customerOrderManager.personalityOneWanted)
        {
            Debug.Log("right personality one added");
            dateQuality += 15;

            if (customerOrderManager.orderGenerator.personalityOneArrayLength == 5)
            {
                if (personalityOneAmount >= (customerOrderManager.personalityOneAmountWanted - 10) && personalityOneAmount <= (customerOrderManager.personalityOneAmountWanted + 10))
                {
                    Debug.Log("Right amout of personality one array length 5");
                    dateQuality += 20;
                }
                else
                {
                    Debug.Log("Wrong amount of personality one array length 5");
                }
            }
            else
            {
                if (personalityOneAmount >= (customerOrderManager.personalityOneAmountWanted - 12.5) && personalityOneAmount <= (customerOrderManager.personalityOneAmountWanted + 12.5))
                {
                    Debug.Log("Right amount of personality one array length 4");
                    dateQuality += 20;
                }
                else
                {
                    Debug.Log("Wrong amount of personality one array length 4");
                }
            }


        }
        else
        {
            Debug.Log("Wrong personality one");
        }

        if (personalityTwo == customerOrderManager.personalityTwoWanted)
        {
            Debug.Log("right personality two added");

            dateQuality += 15;

            if (customerOrderManager.orderGenerator.personalityTwoArrayLength == 5)
            {
                if (personalityTwoAmount >= (customerOrderManager.personalityTwoAmountWanted - 10) && personalityTwoAmount <= (customerOrderManager.personalityTwoAmountWanted + 10))
                {
                    Debug.Log("Right amout of personality two array length 5");
                    dateQuality += 20;
                }
                else
                {
                    Debug.Log("Wrong amount of personality two array length 5");
                }
            }
            else
            {
                if (personalityTwoAmount >= (customerOrderManager.personalityTwoAmountWanted - 12.5) && personalityTwoAmount <= (customerOrderManager.personalityTwoAmountWanted + 12.5))
                {
                    Debug.Log("Right amount of personality two array length 4");
                    dateQuality += 20;
                }
                else
                {
                    Debug.Log("Wrong amount of personality two array length 4");
                }
            }
        }
        else
        {
            Debug.Log("Wrong personality two");
        }
        //}




        //if()
        // if()

    }

    public void CalculateReward()
    {
        customerFinalPayment = dateQuality * 10;
    }
}
