using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeSelection : MonoBehaviour
{
    public Animator eyeAnimator;
    public GameObject returnPosition;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(eyeAnimator == false)
        {
            transform.position = returnPosition.transform.position;
        }
    }

    void OnMouseDown()
    {
        eyeAnimator.SetBool("OnClick 0", true);
        
    }
    
}
