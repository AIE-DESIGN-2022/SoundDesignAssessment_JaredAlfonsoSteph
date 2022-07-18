using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderAcceptanceScript : MonoBehaviour
{
    public GameObject popUpUI;
    public GameObject customerOrderText;
    public GameObject orderTicket;
    public GameObject orderTicketManagerGO;

    public CustomerOrderGenerator customerOrderGenerator;

    public OrderTicketManager orderTicketManager;

    public GameObject orderManagerGO;

    public float newOrderWaitTime;


    void Start()
    {
        orderTicket.SetActive(false);

        //orderTicketManagerGO.SetActive(false);
        //orderManagerGO.SetActive(false);

        OrderPopUp();

        //StartCoroutine(OrderTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OrderPopUp()
    {
        popUpUI.SetActive(true);
        customerOrderText.SetActive(false);
        //orderTicket.SetActive(false);
        
    }

    public void AcceptOrder()
    {
        customerOrderText.SetActive(true);
        orderTicket.SetActive(true);
        //orderManagerGO.SetActive(true);

        popUpUI.SetActive(false);
            
        customerOrderGenerator.GenerateOrder();

        
        //order

        //orderTicketManagerGO.SetActive(true);

        //orderTicketManager.activeOrder = orderTicketManager.orderTickets[orderTicketManager.currentOrderTicket - 1];

        //orderTicketManager.NextOrder();

        Debug.Log("order generate");


    }

    //private IEnumerator OrderTimer()
    //{
       

      //  yield return new WaitForSeconds(newOrderWaitTime);

        // OrderPopUp();
   // }
}
