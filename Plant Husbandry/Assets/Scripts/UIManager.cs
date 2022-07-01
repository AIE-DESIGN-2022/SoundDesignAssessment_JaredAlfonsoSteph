using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject customerOrderSpeech;
    public bool activeBlend;
    //public bool IsBlending { get { return activeBlend != null; } }

    // Start is called before the first frame update
    void Start()
    {
        customerOrderSpeech.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraManager.currentCamera == 0)
        {
            customerOrderSpeech.SetActive(true);
        }
        else
        {
            customerOrderSpeech.SetActive(false);
        }
    }
}
