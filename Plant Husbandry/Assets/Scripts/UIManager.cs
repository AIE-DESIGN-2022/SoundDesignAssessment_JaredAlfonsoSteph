using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{


    public GameObject UI;
    public GameObject mainCamera;

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
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            UI.SetActive(false);
        }
    }
}
