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
    //public int previousOrderTicket;
    //public int nextOrderTicket;

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
    public TextMeshProUGUI maxPaymentText;

    public TextMeshProUGUI activeOrderIndicatorText;

    [Header("CurrentOrderTicket")]

    public GameObject activeOrder = null;
    public Order order;

    public AudioSource buttonClick;


    void Start()
    {
        //AddOrder();

        //activeOrder = orderTickets[currentOrderTicket];

        


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
        maxPaymentText.text = "$1000";
    }
   
    public void NoOrdersAvailable()
    {
        customerOrderTicketNameText.text = " ";

        orderNumberText.text = "No Orders Available" ;
        heightText.text = "accept a new order";
        hairColourText.text = " ";
        eyeColourText.text = " ";
        personalityOneText.text = " ";
        personalityTwoText.text = " ";
        maxPaymentText.text = " ";
    }
    void Update()
    {

        //order.name = "order";


        

        if(orderTickets.Count > 0)
        {
            totalOrderTickets = orderTickets.Count;

            activeOrderIndicatorText.text = (currentOrderTicket + 1) + " / " + totalOrderTickets;

            //UpdateOrderTicketText();
        }
        else
        {
            NoOrdersAvailable();

            activeOrderIndicatorText.text = currentOrderTicket + " / " + totalOrderTickets;
        }
        
        




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

        //activeOrder = orderTickets[currentOrderTicket];

        UpdateOrderTicketText();

        

    }

    public void NextOrder()
    {

        currentOrderTicket++;


        if (currentOrderTicket > totalOrderTickets -1)
        {
            currentOrderTicket = 0;
            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();
        }
        else
        {
            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();

        }

        UpdateOrderTicketText();



    }

    public void PreviousOrder()
    {

        currentOrderTicket--;


        if (currentOrderTicket < 0)
        {
            currentOrderTicket = orderTickets.Count - 1;
            
            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();
        }
        else
        {
            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();

        }



        UpdateOrderTicketText();

        //ChangeOrderNumbers();


    }



    public void CompleteOrder()
    {
        orderTickets.RemoveAt(currentOrderTicket);

        Destroy(activeOrder);

        totalOrderTickets = orderTickets.Count;

        if (totalOrderTickets > 0)
        {
            NextOrder();
        }
        else
        {
            NoOrdersAvailable();
        }

        

        

    }
}
