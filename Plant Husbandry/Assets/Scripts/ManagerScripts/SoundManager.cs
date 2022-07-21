using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource buttonClick;
    // public AudioSource ;
    public AudioRandomiser audioCustomerRandomiser;
    public AudioRandomiser JarPickupAudioRamdomiser;
    public AudioSource BellSound;

    public AudioSource HightSelectSound;
    public AudioSource HightConfirmationSound;
    public AudioSource HightMoveSound;
    public AudioSource PlantIncinerationSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayUIButtonClick()
    {
        buttonClick.Play();

    }
    public void PlayBell()
    {
        BellSound.Play();

    }

    public void PlayPlantIncineration()
    {
        PlantIncinerationSound.Play();

    }

    public void PlayHightMove()
    {
        HightMoveSound.Play();

    }

    public void PlayHightConfirmation()
    {
        HightConfirmationSound.Play();

    }
    public void PlayHightSelect()
    {
        HightSelectSound.Play();

    }
    public void PlayCustomerTalking()
    {
        audioCustomerRandomiser.PlayRandomised();
    }
    public void PlayJarPickupAudio()
    {
        JarPickupAudioRamdomiser.PlayRandomised();
    }

}
