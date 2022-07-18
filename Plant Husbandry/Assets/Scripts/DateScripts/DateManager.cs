using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateManager : MonoBehaviour
{
    public CameraManager cameraManager;
    //public CustomerOrderManager customerOrderManager;
    //public CustomerOrderGenerator customerOrderGenerator;

    public OrderAcceptanceScript orderAcceptance;
    public OrderTicketManager ticketManager;

    public int thisDateQuality;
    public int thisCustomerFinalPayment;
    public string thisFirstName;
    public string thisLastName;
    public string thisPlantName;
    public string thisHairColour;
    public string thisEyeColour;

    [Header("UI")]
    public GameObject dateReviewUI;
    public TextMeshProUGUI evaluationText;
    public TextMeshProUGUI dateReviewText;
    public TextMeshProUGUI amountPaidText;
    public TextMeshProUGUI customerReviewQuoteText;
    public GameObject areaText;
    public MoneyManager moneyManager;

    [Header("EvaluationText")]
    public string bestQualityEvaluation;
    public string goodQualityEvaluation;
    public string okayQualityEvaluation;
    public string badQualityEvaluation;
    public string terribleQualityEvaluation;

    [Header("ReviewText")]
    public string bestQualityReview;
    public string goodQualityReview;
    public string okayQualityReview;
    public string badQualityReview;
    public string terribleQualityReview;



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

    [Header("PlantCharacter")]
    public GameObject plantCharacter;
    public Renderer plantCharacterEye1;
    public Renderer plantCharacterEye2;
    public Renderer plantCharacterHair;


    // Start is called before the first frame update
    void Start()
    {
        dateReviewUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DateReview()
    {
        cameraManager.GoToDate();
        dateReviewUI.SetActive(true);

        SetHairEyeColourDate();

        dateReviewText.text = thisFirstName + " and " + thisPlantName + " " + thisLastName + " were " + thisDateQuality + "% compatible";
        amountPaidText.text = "+ $" + thisCustomerFinalPayment;

        areaText.SetActive(false);

        moneyManager.IncreaseMoney(thisCustomerFinalPayment);

        if (thisDateQuality <= 100 && thisDateQuality > 80)
        {
            evaluationText.text = bestQualityEvaluation;
            customerReviewQuoteText.text = bestQualityReview + " - " + thisFirstName + " " + thisLastName;

        }
        if (thisDateQuality <= 80 && thisDateQuality > 60)
        {
            evaluationText.text = goodQualityEvaluation;
            customerReviewQuoteText.text = goodQualityReview + " - " + thisFirstName + " " + thisLastName;
        }
        if (thisDateQuality <= 60 && thisDateQuality > 40)
        {
            evaluationText.text = okayQualityEvaluation;
            customerReviewQuoteText.text = okayQualityReview + " - " + thisFirstName + " " + thisLastName;
        }
        if (thisDateQuality <= 40 && thisDateQuality > 20)
        {
            evaluationText.text = badQualityEvaluation;
            customerReviewQuoteText.text = badQualityReview + " - " + thisFirstName + " " + thisLastName;
        }
        if (thisDateQuality <= 20 && thisDateQuality >= 0)
        {
            evaluationText.text = terribleQualityEvaluation;
            customerReviewQuoteText.text = terribleQualityReview + " - " + thisFirstName + " " + thisLastName;
        }


    }

    public void ExitDateReview()
    {
        cameraManager.LeaveDate();
        dateReviewUI.SetActive(false);

        areaText.SetActive(true);

        //orderAcceptance.OrderPopUp();
        ticketManager.CompleteOrder();
       
        

    }

    public void SetHairEyeColourDate()
    {
        if (thisEyeColour == "brown")
        {
            plantCharacterEye1.material = brownEyeMaterial;
            plantCharacterEye2.material = brownEyeMaterial;
        }
        if (thisEyeColour == "green")
        {
            plantCharacterEye1.material = greenEyeMaterial;
            plantCharacterEye2.material = greenEyeMaterial;
        }
        if (thisEyeColour == "blue")
        {
            plantCharacterEye1.material = blueEyeMaterial;
            plantCharacterEye2.material = blueEyeMaterial;
        }
        if (thisEyeColour == "yellow")
        {
            plantCharacterEye1.material = yellowEyeMaterial;
            plantCharacterEye2.material = yellowEyeMaterial;
        }
        if (thisEyeColour == "red")
        {
            plantCharacterEye1.material = redEyeMaterial;
            plantCharacterEye2.material = redEyeMaterial;
        }

        if (thisHairColour == "brown")
        {
            plantCharacterHair.material = brownHairMaterial;
        }
        if (thisHairColour == "black")
        {
            plantCharacterHair.material = blackHairMaterial;
        }
        if (thisHairColour == "blonde")
        {
            plantCharacterHair.material = blondeHairMaterial;
        }
        if (thisHairColour == "orange")
        {
            plantCharacterHair.material = orangeHairMaterial;
        }
        if (thisHairColour == "blue")
        {
            plantCharacterHair.material = blueHairMaterial;
        }

    }
}
