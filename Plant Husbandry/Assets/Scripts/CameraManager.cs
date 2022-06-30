using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera shopCounterCamera;
    public CinemachineVirtualCamera gardenCamera;
    public CinemachineVirtualCamera mixingStationCamera;

    public bool isShopCounter;
    public bool isGarden;
    public bool isMixingStation;
  //  public CinemachineVirtualCamera nextCamera;
  //  public CinemachineVirtualCamera previousCamera;
  //  public CinemachineVirtualCamera currentCamera;

    

    // Start is called before the first frame update
    void Start()
    {

        // // currentCamera = shopCounterCamera;
        // nextCamera = mixingStationCamera;
        // previousCamera = gardenCamera;

        isShopCounter = true;
    }

    // Update is called once per frame
    void Update()
    {
        mixingStationCamera.enabled = isMixingStation;
        gardenCamera.enabled = isGarden;
        shopCounterCamera.enabled = isShopCounter;
        
        if (isGarden)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                isShopCounter = true;
                isGarden = false;

                isMixingStation = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                isMixingStation = true;
                isGarden = false;

                isShopCounter = false;
            }
        }

        if (isShopCounter)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                isMixingStation = true;
                isGarden = false;
                isShopCounter = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                isGarden = true;
                isShopCounter = false;
                isMixingStation = false;
            }
        }

        if (isMixingStation)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                isGarden = true;
                isMixingStation = false;

                isShopCounter = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                isShopCounter = true;
                isMixingStation = false;

                isGarden = false;
            }
        }

    }
}
