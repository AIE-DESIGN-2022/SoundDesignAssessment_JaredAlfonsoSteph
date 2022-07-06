using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreyEye : MonoBehaviour
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
        buttonManager.GetComponent<ButtonManager>().eyeSelection = "grey";
        buttonManager.GetComponent<ButtonManager>().lockEyeSection = false;
       
        Debug.Log("numba tree");

    }
}
