using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeConfirm : MonoBehaviour
{
    public Animator redEye;
    public Animator greenEye;
    public Animator yellowEye;
    public Animator brownEye;
    public Animator blueEye;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Jar")
                {
                    Debug.Log("Hit!");
                }
            }
        }
        
    }

    
}
