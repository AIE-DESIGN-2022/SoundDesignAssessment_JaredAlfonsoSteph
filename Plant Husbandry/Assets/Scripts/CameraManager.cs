using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [Header("CameraOrders")]
    public int currentCamera;
    public int previousCamera;
    public int nextCamera;

    public CinemachineVirtualCamera[] cameras;

    public int totalCameras;

 
    void Start()
    {

        //settin gcamera values
        currentCamera = 0;
        previousCamera = totalCameras;
        nextCamera = 1;



        //ensuring current camera is active
        cameras[previousCamera].enabled = false;
        cameras[nextCamera].enabled = false;

        cameras[currentCamera].enabled = true;

    }


    void Update()
    {
        cameras[currentCamera].enabled = true;
        cameras[previousCamera].enabled = false;

        //movement to right
        if (Input.GetKeyDown(KeyCode.D))
        {
            previousCamera = currentCamera;
            currentCamera++;
            nextCamera++;

            ChangeCameraNumbers();


        }
        //movement to left
        if (Input.GetKeyDown(KeyCode.A))
        {
            nextCamera = currentCamera;
            currentCamera--;
            previousCamera--;

            ChangeCameraNumbers();
        }      

    }

    //makes ssure camera order doesn;'t break
    private void ChangeCameraNumbers() 
    {

        if (currentCamera > totalCameras)
        {
            currentCamera = 0;

        }
        if (previousCamera > totalCameras)
        {
            previousCamera = 0;

        }
        if (nextCamera > totalCameras)
        {
            nextCamera = 0;

        }


        if (currentCamera < 0)
        {
            currentCamera = totalCameras;

        }

        if (previousCamera < 0)
        {
            previousCamera = totalCameras;
        }

        if (nextCamera < 0)
        {
            nextCamera = totalCameras;
        }
    }
}
