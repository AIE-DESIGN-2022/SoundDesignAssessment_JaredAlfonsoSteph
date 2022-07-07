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

    // Start is called before the first frame update
    void Start()
    {
        popUpUI.SetActive(true);
        customerOrderText.SetActive(false);
        orderTicket.SetActive(false);
        orderTicketManager.SetActive(false);
        //cutomerOrderManager.SetActive(false);

        //customerOrderGenerator = GameObject.Find("CustomerOrderGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AcceptOrder()
    {
        popUpUI.SetActive(false);
        customerOrderText.SetActive(true);
        orderTicket.SetActive(true);
        orderTicketManager.SetActive(true);

        customerOrderGenerator.GenerateOrder();

    }
}
