using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeHair : MonoBehaviour
{

    public GameObject buttonManager;
    public Animator animator;
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
        buttonManager.GetComponent<ButtonManager>().hairSelection = "blonde";
        buttonManager.GetComponent<ButtonManager>().lockEyeSection = false;
        animator.SetTrigger("cauldron");

        Debug.Log("blonde");

    }
}
