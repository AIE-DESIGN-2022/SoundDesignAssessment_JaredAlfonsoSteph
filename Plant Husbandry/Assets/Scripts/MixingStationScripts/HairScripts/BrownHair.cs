using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownHair : MonoBehaviour
{
    public GameObject hairButtonManager;
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
        hairButtonManager.GetComponent<HairButtonManager>().hairSelection = "brown";
        hairButtonManager.GetComponent<HairButtonManager>().lockHairSection = false;
        animator.SetTrigger("cauldron");

        Debug.Log("brown");

    }
}
