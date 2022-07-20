using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandomiser : MonoBehaviour
{
    public AudioSource[] audioOptions;
    public int audioNumber;
    public AudioSource audioToPlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRandomised()
    {
        audioNumber = Random.Range(0, audioOptions.Length);
        audioToPlay = audioOptions[audioNumber];
        audioToPlay.Play();
    }
}
