using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateManager : MonoBehaviour
{
    public CameraManager cameraManager;
    public CustomerOrderManager customerOrderManager;
    public CustomerNameGenerator customerNameGenerator;

    public OrderAcceptanceScript orderAcceptance;

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

        dateReviewText.text = customerNameGenerator.customerFirstName + " and " + customerNameGenerator.plantName + " " + customerNameGenerator.customerLastName + " were " + customerOrderManager.dateQuality + "% compatible";
        amountPaidText.text = "+ $" + customerOrderManager.customerFinalPayment;

        areaText.SetActive(false);

        moneyManager.IncreaseMoney(customerOrderManager.customerFinalPayment);

        if (customerOrderManager.dateQuality <= 100 && customerOrderManager.dateQuality > 80)
        {
            evaluationText.text = bestQualityEvaluation;
            customerReviewQuoteText.text = bestQualityReview + " - " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;

        }
        if (customerOrderManager.dateQuality <= 80 && customerOrderManager.dateQuality > 60)
        {
            evaluationText.text = goodQualityEvaluation;
            customerReviewQuoteText.text = goodQualityReview + " - " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;
        }
        if (customerOrderManager.dateQuality <= 60 && customerOrderManager.dateQuality > 40)
        {
            evaluationText.text = okayQualityEvaluation;
            customerReviewQuoteText.text = okayQualityReview + " - " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;
        }
        if (customerOrderManager.dateQuality <= 40 && customerOrderManager.dateQuality > 20)
        {
            evaluationText.text = badQualityEvaluation;
            customerReviewQuoteText.text = badQualityReview + " - " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;
        }
        if (customerOrderManager.dateQuality <= 20 && customerOrderManager.dateQuality >= 0)
        {
            evaluationText.text = terribleQualityEvaluation;
            customerReviewQuoteText.text = terribleQualityReview + " - " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;
        }


    }

    public void ExitDateReview()
    {
        cameraManager.LeaveDate();
        dateReviewUI.SetActive(false);

        areaText.SetActive(true);

        orderAcceptance.OrderPopUp();


    }

    public void SetHairEyeColourDate()
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
}
