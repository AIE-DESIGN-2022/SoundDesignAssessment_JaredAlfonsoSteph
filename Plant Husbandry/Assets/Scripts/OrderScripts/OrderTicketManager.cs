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

    [Header("CurrentOrderTicket")]

    public GameObject activeOrder;
    public Order order;

    void Start()
    {
        //orderTicketIsActive = true;

        
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
   
    //public void AddOrder()
    //{
        
        //if (totalOrderTickets > 1)
        //{
            //currentOrderTicket = 0;
          //  previousOrderTicket = currentOrderTicket - 1;
           // nextOrderTicket = currentOrderTicket + 1;
        //}
       // else
       // {
        //    previousOrderTicket = 1;
         //   nextOrderTicket = 1;
        //}
       

        //ChangeOrderNumbers();
    //}

    // Update is called once per frame
    void Update()
    {
        //if (orderNumberText.text == "Order No. 0")
        //{
        //  NextOrder();
        // ChangeOrderNumbers();
        // }


        totalOrderTickets = orderTickets.Count;
        

        //if (orderTickets.Count == 0)
        //{
        // totalOrderTickets = orderTickets.Count;
        //}
        // else
        // {


        // }



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

        

        UpdateOrderTicketText();
        //ensuring current camera is active
        //orderTickets[previousOrderTicket].enabled = false;
        // orderTickets[nextOrderTicket].enabled = false;



        //if(currentOrderTicket < totalOrderTickets)
        // {
        //   currentOrderTicket = 0;
        // }
        // if (currentOrderTicket > totalOrderTickets)
        // {
        //  currentOrderTicket = 0;

        // }
        //if (currentOrderTicket < 0)
        // {
        //   currentOrderTicket = totalOrderTickets;

        //}

        //ChangeOrderNumbers();
    }

    public void NextOrder()
    {
        //previousOrderTicket++;

        //nextOrderTicket++;

        //if (currentOrderTicket < totalOrderTickets)
        //{
        //currentOrderTicket = 0;

        

        if (currentOrderTicket < totalOrderTickets)
        {
            currentOrderTicket++;

            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();

            //currentOrderTicket = 0;
        }
        if (currentOrderTicket >= totalOrderTickets)
        {
            //currentOrderTicket++;

            currentOrderTicket = 0;

            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();

        }
        if (currentOrderTicket < 0)
        {
            currentOrderTicket++;

            currentOrderTicket = totalOrderTickets;

            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();

        }
        if ( currentOrderTicket == totalOrderTickets)
        {
            Debug.Log("AAHH");

            currentOrderTicket = 0;

            activeOrder = orderTickets[currentOrderTicket];
            order = activeOrder.GetComponent<Order>();
        }
        // }
        // if (currentOrderTicket > totalOrderTickets)
        //{
        //   currentOrderTicket = 0;

        //}
        //if (currentOrderTicket < 0)
        // {
        // currentOrderTicket = totalOrderTickets;

        //}

        UpdateOrderTicketText();

        ChangeOrderNumbers();

    }

    public void PreviousOrder()
    {
        //nextOrderTicket--;
        currentOrderTicket--;
        //previousOrderTicket--;

        activeOrder = orderTickets[currentOrderTicket];
        order = activeOrder.GetComponent<Order>();

        UpdateOrderTicketText();

        ChangeOrderNumbers();


    }

    public void ChangeOrderNumbers()
    {
        if (currentOrderTicket > totalOrderTickets)
        {
            currentOrderTicket = 0;

        }
       // if (previousOrderTicket > totalOrderTickets)
       // {
        //    previousOrderTicket = 0;

       // }
       // if (nextOrderTicket > totalOrderTickets)
       // {
         //   nextOrderTicket = 0;

       // }


        if (currentOrderTicket < 0)
        {
            currentOrderTicket = totalOrderTickets;

        }

       // if (previousOrderTicket < 0)
        //{
          //  previousOrderTicket = totalOrderTickets;
       // }

       // if (nextOrderTicket < 0)
        //{
        //    nextOrderTicket = totalOrderTickets;
       // }
    } 

    public void CompleteOrder()
    {
        
        orderTickets.RemoveAt(currentOrderTicket);

        Destroy(activeOrder);

        NextOrder();

    }
}
