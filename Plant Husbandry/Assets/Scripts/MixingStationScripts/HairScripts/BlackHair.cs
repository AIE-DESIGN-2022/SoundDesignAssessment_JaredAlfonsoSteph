using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHair : MonoBehaviour
{
    public GameObject hairButtonManager;
    public Animator animator;
    public AudioRandomiser randomiser;
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
        hairButtonManager.GetComponent<HairButtonManager>().hairSelection = "voidy";
        hairButtonManager.GetComponent<HairButtonManager>().lockHairSection = false;
        animator.SetTrigger("cauldron");
        randomiser.PlayRandomised();
        Debug.Log("black");

    }
}
