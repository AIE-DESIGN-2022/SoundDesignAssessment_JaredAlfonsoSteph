using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerNameGenerator : MonoBehaviour
{

    public string[] firstNames = new string[50];
    public string customerFirstName;
    public int customerFirstNameNumber;

    public string[] lastNames = new string[50];
    public string customerLastName;
    public int customerLastNameNumber;

    public TextMeshProUGUI customerNameText;
    public TextMeshProUGUI customerOrderNameText;

    public string[] plantNames = new string[50];
    public string plantName;
    public int plantNameNumber;


    // Start is called before the first frame update
    void Start()
    {
        GenerateCustomerName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCustomerName()
    {
        customerFirstNameNumber = Random.Range(0, firstNames.Length);
        customerFirstName = firstNames[customerFirstNameNumber];



        customerLastNameNumber = Random.Range(0, lastNames.Length);
        customerLastName = lastNames[customerLastNameNumber];

        customerNameText.text = customerFirstName + " " + customerLastName;

        customerOrderNameText.text = "for " + customerFirstName + " " + customerLastName;

        plantNameNumber = Random.Range(0, plantNames.Length);
        plantName = plantNames[plantNameNumber];
    }

    public void GeneratePlantName()
    {

    }
}
