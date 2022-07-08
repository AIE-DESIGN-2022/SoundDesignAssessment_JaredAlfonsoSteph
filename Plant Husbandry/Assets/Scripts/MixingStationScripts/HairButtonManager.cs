using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairButtonManager : MonoBehaviour
{
    //Responsible for allowing/not allowing the player to press other jars.
    public bool lockHairSection;

    public Button blondeJar;
    public Button blackJar;
    public Button orangeJar;
    public Button brownJar;
    public Button blueJar;

    public Animator blondeHairAnim;
    public Animator orangeHairAnim;
    public Animator blackHairAnim;
    public Animator brownHairAnim;
    public Animator blueHairAnim;

    public bool blondeActive;
    public bool orangeActive;
    public bool blueActive;
    public bool brownActive;
    public bool blackActive;

    public string hairSelection;

    // Start is called before the first frame update
    void Start()
    {
        lockHairSection = true;

        blondeActive = false;
        orangeActive = false;
        blueActive = false;
        brownActive = false;
        blackActive = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Returns all eyes back to their jars.
        //-------------------------------------------------------------//
        if (blondeActive == false)
        {
            blondeHairAnim.SetBool("Return", true);
        }

        if (orangeActive == false)
        {
            orangeHairAnim.SetBool("Return", true);
        }

        if (blueActive == false)
        {
            blueHairAnim.SetBool("Return", true);
        }

        if (blackActive == false)
        {
            blackHairAnim.SetBool("Return", true);
        }

        if (brownActive == false)
        {
            brownHairAnim.SetBool("Return", true);
        }
        //-------------------------------------------------------------//

    }

    //public voids check if player can access other jars still, if they can it will bring the item from the jar forward and all other objects back.
    public void YellowButtonClicked()
    {

        if (lockHairSection == true)
        {
            blondeActive = true;
            orangeActive = false;
            blueActive = false;
            brownActive = false;
            blackActive = false;
            blondeHairAnim.SetTrigger("OnClick");
            blondeHairAnim.SetBool("Return", false);
        }



    }

    public void OrangeButtonClicked()
    {
        if (lockHairSection == true)
        {
            blondeActive = false;
            orangeActive = true;
            blueActive = false;
            brownActive = false;
            blackActive = false;
            orangeHairAnim.SetTrigger("OnClick");
            orangeHairAnim.SetBool("Return", false);
        }



    }

    public void BlueButtonClicked()
    {
        if (lockHairSection == true)
        {
            blondeActive = false;
            orangeActive = false;
            blueActive = true;
            brownActive = false;
            blackActive = false;
            blueHairAnim.SetTrigger("OnClick");
            blueHairAnim.SetBool("Return", false);
        }



    }

    public void BrownButtonClicked()
    {
        if (lockHairSection == true)
        {
            blondeActive = false;
            orangeActive = false;
            blueActive = false;
            brownActive = true;
            blackActive = false;
            brownHairAnim.SetTrigger("OnClick");
            brownHairAnim.SetBool("Return", false);
        }



    }

    public void BlackButtonClicked()
    {
        if (lockHairSection == true)
        {
            blondeActive = false;
            orangeActive = false;
            blueActive = false;
            brownActive = false;
            blackActive = true;
            blackHairAnim.SetTrigger("OnClick");
            blackHairAnim.SetBool("Return", false);
        }



    }

    public void ResetHairButtonManager()
    {
        lockHairSection = true;

        blondeActive = false;
        orangeActive = false;
        blueActive = false;
        brownActive = false;
        blackActive = false;

        hairSelection = "";
    }
}
