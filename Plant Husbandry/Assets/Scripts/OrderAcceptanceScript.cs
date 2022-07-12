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

   // public Order

    //public CustomerNameGenerator customerNameGenerator;

    // Start is called before the first frame update
    void Start()
    {
        OrderPopUp();
        //customerNameGenerator .GenerateCustomerName();
        //cutomerOrderManager.SetActive(false);

        //customerOrderGenerator = GameObject.Find("CustomerOrderGenerator");

        orderTicketManagerGO.SetActive(false);
        orderManagerGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OrderPopUp()
    {
        popUpUI.SetActive(true);
        customerOrderText.SetActive(false);
        orderTicket.SetActive(false);
        
    }

    public void AcceptOrder()
    {
        //popUpUI.SetActive(false);
       
       

        customerOrderGenerator.GenerateOrder();

        //orderTicketManager.AddOrder();
        orderTicketManagerGO.SetActive(true);

       
        //orderTicketManager.UpdateOrderTicketText();

        customerOrderText.SetActive(true);
        orderTicket.SetActive(true);
        orderManagerGO.SetActive(true);

        Debug.Log("First order generate");

        //orderTicketManager.UpdateOrderTicketText();
        //GenerateCustomerName();
        // customerOrderGenerator.GenerateOrder();
        // Debug.Log("First order generate");
    }


}
