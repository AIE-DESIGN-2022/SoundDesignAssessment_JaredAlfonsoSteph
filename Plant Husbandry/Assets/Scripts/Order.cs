using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public int number;

    public GameObject customerOrderGenerator;
    public CustomerOrderGenerator orderGenerator;

    public GameObject orderTicketManager;
    public OrderTicketManager ticketManager;

    public string orderFirstName;
    public string orderLastName;
    public string orderPlantName;

    public string orderHeight;
    public int orderHeightNumber;

    public string orderEyeColour;

    public string orderHairColour;

    public string orderPersonalityOne;
    public int orderPersonalityOneNumber;
    //public float orderPersonalityOneAmount;

    public string orderPersonalityTwo;
    public int orderPersonalityTwoNumber;
    //public float orderPersonalityTwoAmount;

    [Header("Personality Output")]
    public string orderPersonalityOneLevel;

    public string orderPersonalityTwoLevel;

    public int orderPersonalityOneArrayLength;

    public int orderPersonalityTwoArrayLength;

    // Start is called before the first frame update
    void Start()
    {
        orderTicketManager = GameObject.Find("OrderTicketManager");
        ticketManager = orderTicketManager.GetComponent<OrderTicketManager>();

        ticketManager.orderTickets.Add(this.gameObject);

        customerOrderGenerator = GameObject.Find("CustomerOrderGenerator");
        orderGenerator = customerOrderGenerator.GetComponent<CustomerOrderGenerator>();

        number = orderGenerator.orderNumber;
        orderFirstName = orderGenerator.customerFirstName;
        orderLastName = orderGenerator.customerLastName;
        orderPlantName = orderGenerator.plantName;

        orderHeight = orderGenerator.currentHeight;
        orderHeightNumber = orderGenerator.heightNumber;

        orderEyeColour = orderGenerator.currentEyeColour;

        orderHairColour = orderGenerator.currentHairColour;

        orderPersonalityOne = orderGenerator.currentPersonalityTraitOne;
        orderPersonalityOneNumber = orderGenerator.personalityTraitOneNumber;
        //orderPersonalityOneAmount = orderGenerator.

        orderPersonalityTwo = orderGenerator.currentPersonalityTraitTwo;
        orderPersonalityTwoNumber = orderGenerator.personalityTraitTwoNumber;

        orderPersonalityOneLevel = orderGenerator.currentPersonalityTraitOneLevel;
        orderPersonalityTwoLevel = orderGenerator.currentPersonalityTraitTwoLevel;

        orderPersonalityOneArrayLength = orderGenerator.personalityOneArrayLength;
        orderPersonalityTwoArrayLength = orderGenerator.personalityTwoArrayLength;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
