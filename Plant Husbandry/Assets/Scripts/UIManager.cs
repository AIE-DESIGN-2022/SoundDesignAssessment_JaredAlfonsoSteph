using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{


    public GameObject UI;
    public GameObject mainCamera;

    public string areaName;
    public string areaToPrint;

    public TextMeshProUGUI areaNameText;

    // Start is called before the first frame update
    void Start()
    {
        //customerOrderSpeech.SetActive(false);

        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "MainCamera")
        {
            UI.SetActive(true);
            areaToPrint = areaName;
            areaNameText.text = areaName;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            UI.SetActive(false);
            areaToPrint = null;
            areaNameText.text = areaName;
        }
    }


}
