using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderTicketManager : MonoBehaviour
{
    public GameObject orderTicketBackground;
    private bool orderTicketIsActive;

    public CustomerOrderGenerator orderGenerator;

    [Header("OrderTicket")]
    public int currentOrderTicket;
    public int previousOrderTicket;
    public int nextOrderTicket;

    public int totalOrderTickets;

    public List<GameObject> orderTickets;

    [Header("OrderTicketUI")]
    public TextMeshProUGUI orderNumberText;
    //public int orderNumber = 0;
    //public TextMeshProUGUI speechCustomerNameText;
    public TextMeshProUGUI customerOrderTicketNameText;
    public TextMeshProUGUI heightText;
    public TextMeshProUGUI hairColourText;
    public TextMeshProUGUI eyeColourText;
    public TextMeshProUGUI personalityOneText;
    public TextMeshProUGUI personalityTwoText;

    [Header("CurrentOrderTicket")]

    public GameObject activeOrder;
    public Order order;

    void Start()
    {
        //orderTicketIsActive = true;
        //UpdateOrderTicketText();

    }

    public void UpdateOrderTicketText()
    {
        customerOrderTicketNameText.text = "for " + order.orderFirstName + " " + order.orderLastName;

        orderNumberText.text = "Order No. " + order.number;
        heightText.text = "- " + order.orderHeight;
        hairColourText.text = "- " + order.orderHairColour + " hair";
        eyeColourText.text = "- " + order.orderEyeColour + " eyes";
        personalityOneText.text = "- " + order.orderPersonalityOneLevel;
        personalityTwoText.text = "- " + order.orderPersonalityTwoLevel;
    }
   

    // Update is called once per frame
    void Update()
    {
        activeOrder = orderTickets[currentOrderTicket];
        order = activeOrder.GetComponent<Order>();

        totalOrderTickets = orderTickets.Count;
        

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (orderTicketIsActive)
            {
                orderTicketIsActive=false;
                orderTicketBackground.SetActive(false);
            }
            else
            {
                orderTicketIsActive = true;
                orderTicketBackground.SetActive(true);
            }
        }

    }

    public void AddOrder()
    {
        currentOrderTicket = 0;
        previousOrderTicket = totalOrderTickets;
        nextOrderTicket = 1;


        //UpdateOrderTicketText();
        //ensuring current camera is active
        //orderTickets[previousOrderTicket].enabled = false;
        // orderTickets[nextOrderTicket].enabled = false;

        //orderTickets[currentOrderTicket].enabled = true;
    }

    public void NextOrder()
    {
        previousOrderTicket++;
        currentOrderTicket++;
        nextOrderTicket++;

        

        ChangeOrderNumbers();

        UpdateOrderTicketText();

        //UpdateOrderTicketText();

        //orderTickets[currentCamera].enabled = true;
        //orderTickets[previousCamera].enabled = false;
        //cameras[nextCamera].enabled = false;
    }

    public void PreviousOrder()
    {
        nextOrderTicket--;
        currentOrderTicket--;
        previousOrderTicket--;

        //noMoneyText.SetActive(false);

        

        ChangeOrderNumbers();

        UpdateOrderTicketText();
        //UpdateOrderTicketText();

        //cameras[currentCamera].enabled = true;
        //cameras[previousCamera].enabled = false;
        // cameras[nextCamera].enabled = false;
    }

    public void ChangeOrderNumbers()
    {
        if (currentOrderTicket > totalOrderTickets)
        {
            currentOrderTicket = 0;

        }
        if (previousOrderTicket > totalOrderTickets)
        {
            previousOrderTicket = 0;

        }
        if (nextOrderTicket > totalOrderTickets)
        {
            nextOrderTicket = 0;

        }


        if (currentOrderTicket < 0)
        {
            currentOrderTicket = totalOrderTickets;

        }

        if (previousOrderTicket < 0)
        {
            previousOrderTicket = totalOrderTickets;
        }

        if (nextOrderTicket < 0)
        {
            nextOrderTicket = totalOrderTickets;
        }
    }
}
