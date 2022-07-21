using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        buttonClick.Play();
        SceneManager.LoadScene("MainScene");
        buttonClick.Play();
    }

    public void QuitGame()
    {
        buttonClick.Play();
        Debug.Log("QuitGame");
        Application.Quit();
    }

    public void StartScene()
    {
        buttonClick.Play();
        SceneManager.LoadScene("StartScene");
    }
}
