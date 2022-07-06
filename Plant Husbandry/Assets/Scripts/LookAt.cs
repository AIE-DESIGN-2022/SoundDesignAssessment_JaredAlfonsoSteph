using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject mainCamera;
    private Transform mainCameraTransform;
    private Transform thisGameObject;
   
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");

         mainCameraTransform = mainCamera.GetComponent<Transform>();

        thisGameObject = this.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        thisGameObject.LookAt(mainCameraTransform);
    }
}
