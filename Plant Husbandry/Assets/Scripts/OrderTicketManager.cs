using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderTicketManager : MonoBehaviour
{
    public GameObject orderTicketBackground;
    private bool orderTicketIsActive;
     public CustomerNameGenerator customerNameGenerator;
    public TextMeshProUGUI customerNameText;
    
    // Start is called before the first frame update
    void Start()
    {
        orderTicketIsActive = true;

        customerNameText.text = "for " + customerNameGenerator.customerFirstName + " " + customerNameGenerator.customerLastName;
        Debug.Log(customerNameGenerator.customerFirstName + customerNameGenerator.customerLastName);
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
