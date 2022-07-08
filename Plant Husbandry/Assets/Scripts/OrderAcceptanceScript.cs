using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderAcceptanceScript : MonoBehaviour
{
    public GameObject popUpUI;
    public GameObject customerOrderText;
    public GameObject orderTicket;
    public GameObject orderTicketManager;

    public CustomerOrderGenerator customerOrderGenerator;

    public CustomerNameGenerator customerNameGenerator;

    // Start is called before the first frame update
    void Start()
    {
        OrderPopUp();
        //customerNameGenerator .GenerateCustomerName();
        //cutomerOrderManager.SetActive(false);

        //customerOrderGenerator = GameObject.Find("CustomerOrderGenerator");
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
        orderTicketManager.SetActive(false);
    }

    public void AcceptOrder()
    {
        popUpUI.SetActive(false);
        customerOrderText.SetActive(true);
        orderTicket.SetActive(true);
        orderTicketManager.SetActive(true);

        customerOrderGenerator.GenerateOrder();
        customerNameGenerator.GenerateCustomerName();

    }


}
