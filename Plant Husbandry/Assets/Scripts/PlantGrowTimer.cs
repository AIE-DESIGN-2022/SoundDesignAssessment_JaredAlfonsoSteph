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

    // Start is called before the first frame update
    void Start()
    {
        timeStageOne = secondsLeft * (timerPercentageStageOne/100);
        timeStageTwo = secondsLeft * (timerPercentageStageTwo / 100);
        timeStageThree = secondsLeft * (timerPercentageStageThree / 100);
        PlantCharacter.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        timerOn = false;

        plantReadyButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            secondsLeft -= Time.deltaTime;
            UpdateTimer(secondsLeft);
        }
       // else
        //{
          //  Debug.Log("Plant is grown");
         //   secondsLeft = 0;
      //   //   timerOn = false;
       // }

        if(secondsLeft <= timeStageThree)
        {
            Debug.Log("Stage Three");
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(1f, maxHeightAdded, 1f), Time.deltaTime * growTime);

        }   
        else if(secondsLeft <= timeStageTwo)
        {
            Debug.Log("Stage Two");
            PlantCharacter.transform.localScale = Vector3.Lerp(PlantCharacter.transform.localScale, new Vector3(0.6f, 0.6f, 0.6f), Time.deltaTime * growTime);


        }
        else if (secondsLeft <= timeStageOne)
        {
            Debug.Log("Stage One");
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

    public void StartTimer()
    {
        timerOn = true;
        fertilizerButton.SetActive(false);
    }

    public void SellPlant()
    {
        popUpUI.SetActive(true);
        questionText.text = "Sell Plant-Husband";
    }

    public void YesSell()
    {
        //
        plantCharacter.SetActive(false);
        popUpUI.SetActive(false);

        Debug.Log("Sell Plant");

    }

    public void NoSell()
    {
        //???
        Debug.Log("No Sell Plant");
    }
}
