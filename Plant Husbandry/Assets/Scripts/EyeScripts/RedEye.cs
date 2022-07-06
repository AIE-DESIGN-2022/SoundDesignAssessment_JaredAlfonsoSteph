using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEye : MonoBehaviour
{

    public GameObject buttonManager;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        buttonManager.GetComponent<ButtonManager>().eyeSelection = "red";
        buttonManager.GetComponent<ButtonManager>().lockEyeSection = false;
       
        Debug.Log("numba one");

    }
}
