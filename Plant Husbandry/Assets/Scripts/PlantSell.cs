using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlantSell : MonoBehaviour
{
    public GameObject popUpUI;
    public TextMeshProUGUI questionText;
    public GameObject plantCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    }

    public void NoSell()
    {
        //???
    }
}
