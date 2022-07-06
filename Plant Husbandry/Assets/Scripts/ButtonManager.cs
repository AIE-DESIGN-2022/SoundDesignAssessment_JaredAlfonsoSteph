using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    //Responsible for allowing/not allowing the player to press other jars.
    public bool lockEyeSection;
    
    public Button greenJar;
    public Button redJar;
    public Button greyJar;
    public Button brownJar;
    public Button blueJar;

    public GameObject greenEye;
    public GameObject redEye;
    public GameObject greyEye;
    public GameObject brownEye;
    public GameObject blueEye;

    public Animator greenEyeAnim;
    public Animator redEyeAnim;
    public Animator greyEyeAnim;
    public Animator brownEyeAnim;
    public Animator blueEyeAnim;

    public bool redActive;
    public bool greyActive; 
    public bool blueActive;
    public bool brownActive;    
    public bool greenActive;

    public string eyeSelection;

    // Start is called before the first frame update
    void Start()
    {
        lockEyeSection = true;
        
        redActive = false;
        greyActive = false;
        blueActive = false;
        brownActive = false;
        greenActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Returns all eyes back to their jars.
        //-------------------------------------------------------------//
        if(redActive == false)
        {
            redEyeAnim.SetBool("Return", true);
        }

        if(greyActive == false)
        {
            greyEyeAnim.SetBool("Return", true);
        }

        if(blueActive == false)
        {
            blueEyeAnim.SetBool("Return", true);
        }

        if(greenActive == false)
        {
            greenEyeAnim.SetBool("Return", true);
        }

        if(brownActive == false)
        {
            brownEyeAnim.SetBool("Return", true);
        }
        //-------------------------------------------------------------//

    }

    //public voids check if player can access other jars still, if they can it will bring the item from the jar forward and all other objects back.
    public void RedButtonClicked()
    {
        
        if(lockEyeSection == true)
        {
            redActive = true;
            greyActive = false;
            blueActive = false;
            brownActive = false;
            greenActive = false;
            redEyeAnim.SetTrigger("OnClick");
            redEyeAnim.SetBool("Return", false);
        }
            


    }

    public void GreyButtonClicked()
    {
        if (lockEyeSection == true)
        {
            redActive = false;
            greyActive = true;
            blueActive = false;
            brownActive = false;
            greenActive = false;
            greyEyeAnim.SetTrigger("OnClick");
            greyEyeAnim.SetBool("Return", false);
        }
        


    }

    public void BlueButtonClicked()
    {
        if (lockEyeSection == true)
        {
            redActive = false;
            greyActive = false;
            blueActive = true;
            brownActive = false;
            greenActive = false;
            blueEyeAnim.SetTrigger("OnClick");
            blueEyeAnim.SetBool("Return", false);
        }
        


    }

    public void BrownButtonClicked()
    {
        if (lockEyeSection == true)
        {
            redActive = false;
            greyActive = false;
            blueActive = false;
            brownActive = true;
            greenActive = false;
            brownEyeAnim.SetTrigger("OnClick");
            brownEyeAnim.SetBool("Return", false);
        }
        


    }

    public void GreenButtonClicked()
    {
        if (lockEyeSection == true)
        {
            redActive = false;
            greyActive = false;
            blueActive = false;
            brownActive = false;
            greenActive = true;
            greenEyeAnim.SetTrigger("OnClick");
            greenEyeAnim.SetBool("Return", false);
        }
        


    }
}
