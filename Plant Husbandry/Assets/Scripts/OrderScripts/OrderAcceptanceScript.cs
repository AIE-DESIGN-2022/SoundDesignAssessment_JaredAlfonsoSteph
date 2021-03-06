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
    public GameObject customerWaiting;

    public CustomerOrderGenerator customerOrderGenerator;

    public OrderTicketManager orderTicketManager;

    public GameObject orderManagerGO;

    public float newOrderWaitTime;

    public AudioSource newCustomerOrderBell;
    public AudioSource orderTicketWriteAudio;


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

        customerWaiting.SetActive(true);
        //orderTicket.SetActive(false);
        newCustomerOrderBell.Play();


    }

    public void AcceptOrder()
    {
        customerOrderText.SetActive(true);
        orderTicket.SetActive(true);
        //orderManagerGO.SetActive(true);
        customerWaiting.SetActive(false);

        popUpUI.SetActive(false);
            
        customerOrderGenerator.GenerateOrder();
        orderTicketWriteAudio.Play();
        
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
