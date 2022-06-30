using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera shopCounterCamera;
    public CinemachineVirtualCamera gardenCamera;
    public CinemachineVirtualCamera mixingStationCamera;

    private bool isShopCounter;
    private bool isGarden;
    private bool isMixingStation;
    private CinemachineVirtualCamera nextCamera;
    private CinemachineVirtualCamera previousCamera;
    // Start is called before the first frame update
    void Start()
    {
        shopCounterCamera.enabled = true;
        gardenCamera.enabled = false;
        mixingStationCamera.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            nextCamera.enabled = true;

            if (isGarden)
            {
                nextCamera = shopCounterCamera;
                previousCamera = mixingStationCamera;
            }

            if (isShopCounter)
            {
                nextCamera = mixingStationCamera;
                previousCamera = gardenCamera;
            }

            if (isMixingStation)
            {
                nextCamera = gardenCamera;
                previousCamera = shopCounterCamera;
            }
        }
    }
}
