using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderTicketManager : MonoBehaviour
{
    public GameObject orderTicketBackground;
    private bool orderTicketIsActive;

    void Start()
    {
        orderTicketIsActive = true;


    }

    // Update is called once per frame
    void Update()
    {
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
}
