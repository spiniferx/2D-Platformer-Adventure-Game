using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Canvas creditCanvas;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        creditCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Debug.Log("Play Clicked");
        SceneManager.LoadScene("levelselector");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void credit()
    {
        creditCanvas.enabled = true;
    }
    public void sound()
    {
        audioSource.mute = !audioSource.mute;
    }
    public void back()
    {
        creditCanvas.enabled = false;
    }


}
