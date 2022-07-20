using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotAudioManager : MonoBehaviour
{
    public AudioSource plantGrowAudio;
    public AudioSource plantReadyAudio;
    public AudioSource buttonClickAudio;
    public AudioSource addFertilizerAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlantGrowAudio()
    {
        plantGrowAudio.Play();
    }
    public void PlantReadyAudio()
    {
        plantReadyAudio.Play();
    }

    public void PotButtonClick()
    {
        buttonClickAudio.Play();
    }

    public void AddFertilizerAudio()
    {
        addFertilizerAudio.Play();
    }
}
