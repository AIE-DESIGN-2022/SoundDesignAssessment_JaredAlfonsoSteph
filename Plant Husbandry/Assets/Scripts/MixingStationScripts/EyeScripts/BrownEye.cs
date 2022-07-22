using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownEye : MonoBehaviour
{
    public GameObject buttonManager;
    public Animator animator;
    public AudioRandomiser audioRandomiser;

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
        buttonManager.GetComponent<ButtonManager>().eyeSelection = "dirty";
        buttonManager.GetComponent<ButtonManager>().lockEyeSection = false;
        animator.SetTrigger("cauldron");
        Debug.Log("numba fou");
        audioRandomiser.PlayRandomised();
    }
}
