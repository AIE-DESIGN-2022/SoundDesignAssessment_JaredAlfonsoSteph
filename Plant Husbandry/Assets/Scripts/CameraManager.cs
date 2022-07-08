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

    public AudioSource cameraMoveSound;

    public GameObject noMoneyText;

    public CinemachineVirtualCamera dateCam;

   // public string activeCamera;

    void Start()
    {
        //activeCamera = ;

        //settin gcamera values
        currentCamera = 0;
        previousCamera = totalCameras;
        nextCamera = 1;

        //ensuring current camera is active
        cameras[previousCamera].enabled = false;
        cameras[nextCamera].enabled = false;

        cameras[currentCamera].enabled = true;

        //dateCam.enabled = false;

    }


    void Update()
    {


        //movement to right
        if (Input.GetKeyDown(KeyCode.D))
        {
            previousCamera++;
            currentCamera++;
            nextCamera++;

            noMoneyText.SetActive(false);

            ChangeCameraNumbers();

            cameras[currentCamera].enabled = true;
            cameras[previousCamera].enabled = false;
            cameras[nextCamera].enabled = false;


        }
        //movement to left
        if (Input.GetKeyDown(KeyCode.A))
        {
            nextCamera--;
            currentCamera--;
            previousCamera--;

            noMoneyText.SetActive(false);

            ChangeCameraNumbers();

            cameras[currentCamera].enabled = true;
            cameras[previousCamera].enabled = false;
            cameras[nextCamera].enabled = false;
        }      

    }

    //makes ssure camera order doesn;'t break
    private void ChangeCameraNumbers() 
    {
        cameraMoveSound.Play();

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

    public void GoToDate()
    {
        dateCam.Priority = 12;
        dateCam.enabled = true;
    }

    public void LeaveDate()
    {
        dateCam.Priority = 10;
        dateCam.enabled = false;

        ChangeCameraNumbers();

        //currentCamera = 0;
        cameras[currentCamera].enabled = true;
        cameras[previousCamera].enabled = false;
        cameras[nextCamera].enabled = false;

        
    }
}
